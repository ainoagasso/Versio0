using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlightLib;


namespace FlightSimulator
{
    public partial class SimulationForm : Form
    {
        FlightPlan plan1;
        FlightPlan plan2;
        private double tiempoCiclo;

        private bool simulacionEnEjecucion = false;

        int estado = 0; // 0 = parado, 1 = en ejecución
        public double distanciaSeguridad;

        public SimulationForm(FlightPlan p1, FlightPlan p2, double tiempoCiclo, double distanciaSeguridad)
        {
            InitializeComponent();
            this.plan1 = p1;
            this.plan2 = p2;
            this.tiempoCiclo = tiempoCiclo;
            this.distanciaSeguridad = distanciaSeguridad;
        }

        private Image originalImage1;
        private Image originalImage2;
        private void SimulationForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            // Guardem la imatge inicial original clonant-la abans de girar-la
            if (pbAvion1.Image != null) 
                originalImage1 = (Image)pbAvion1.Image.Clone();
            if (pbAvion2.Image != null) originalImage2 = (Image)pbAvion2.Image.Clone();

            if (plan1 != null)
            {
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX() - (pbAvion1.Width / 2), (int)plan1.GetCurrentPosition().GetY() - (pbAvion1.Height / 2));
                pbAvion1.Tag = plan1;
            }

            if (plan2 != null)
            {
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX() - (pbAvion2.Width / 2), (int)plan2.GetCurrentPosition().GetY() - (pbAvion2.Height / 2));
                pbAvion2.Tag = plan2;
            }

            //estableixo el color de fons dels PictureBox a transparent perquè més tard es vegin les elipses
            pbAvion1.BackColor = Color.Transparent;
            pbAvion2.BackColor = Color.Transparent;
            // Mirem que hi hagi els plans de vol i comprovem si hi ha conflicte abans de començar la simulació
            if (plan1 != null && plan2 != null)
            {
                if (plan1.PredecirConflicto(plan1, plan2, distanciaSeguridad))
                {
                    // Preguntem si volem resoldre el conflicte abans de començar la simulació
                    if (MessageBox.Show("Els vols entraran en conflicte. ¿Vols resoldre el conflicte?", "Conflicte detectat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Si diu que si augmentem la velocitat del vol 1 fins que no hi hagi conflicte
                        while (plan1.PredecirConflicto(plan1, plan2, distanciaSeguridad) && plan1.GetVelocidad() < 1000)
                        {
                            plan1.SetVelocidad(plan1.GetVelocidad() + 10.0);
                        }
                        if (plan1.PredecirConflicto(plan1, plan2, distanciaSeguridad))
                        {
                            while (plan1.PredecirConflicto(plan1, plan2, distanciaSeguridad) && plan1.GetVelocidad() > 0)
                            {
                                plan1.SetVelocidad(plan1.GetVelocidad() - 10.0);
                            }
                        }

                        MessageBox.Show("La velocitat del vol 1 s'ha ajustat a " + plan1.GetVelocidad() + " per evitar el conflicte.");
                        // Si diu que no, ignora el codi i continua amb la simulació
                    }
                }
            }

            numVelocidad1.Value = (decimal)plan1.GetVelocidad();
            numVelocidad2.Value = (decimal)plan2.GetVelocidad();
            HeadingAvio(pbAvion1, plan1, originalImage1);
            HeadingAvio(pbAvion2, plan2, originalImage2);
            ComprobarAlarmaConflicto();
        }

        private void Mover_Click(object sender, EventArgs e)
        {

            if (plan1 != null && !plan1.HasArrived())
            {
                plan1.Move(tiempoCiclo);
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX() - (pbAvion1.Width / 2), (int)plan1.GetCurrentPosition().GetY() - (pbAvion1.Height / 2));

            }

            // Movem el segon avió amb el temps de cicle rebut de la Fase 2
            if (plan2 != null && !plan2.HasArrived())
            {
                plan2.Move(tiempoCiclo);
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX() - (pbAvion2.Width / 2), (int)plan2.GetCurrentPosition().GetY() - (pbAvion2.Height / 2));

            }

            if (plan1 != null && plan2 != null)
            {
                bool conflicto = plan1.Conflicto(plan2, distanciaSeguridad);
                if (conflicto)
                {
                    labelAlarma.Text = "ALERTA: Els vols es troben en conflicte!"; //poso l'alarma que avisa si els vols estan en conflicte
                }
                else
                {
                    labelAlarma.Text = "";
                }
            }


            panelMap.Invalidate(); // Forcem la finestra a redibuixar-se per actualitzar la línia de trajectòria i l'elipse de seguretat
            panelMap.Update(); // Forcem la finestra a actualitzar-se per mostrar els canvis immediatament
        }

        private void pbAvion1_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm(plan1);
            info.ShowDialog();
        }

        private void pbAvion2_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm(plan2);
            info.ShowDialog();
        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            {
                //FASE 6: dibuixar la trajectòria dels vols

                Graphics g = e.Graphics; //és l'objecte gràfic que ens permetrà dibuixar a la finestra

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //suavitzar lineas

                g.Clear(panelMap.BackColor); //netejo la finestra abans de dibuixar

                Pen Trajectoria = new Pen(Color.Blue, 2); //creem un llapis de color blau i gruix 2 per fer la trajectòria dels vols

                //Perquè el boli sàpiga on pintar, li passem les coordenades de la posició actual i de la posició final del vol 1

                float origenX1 = (float)plan1.GetInitialPosition().GetX();
                float origenY1 = (float)plan1.GetInitialPosition().GetY();
                float finalX1 = (float)plan1.GetFinalPosition().GetX();
                float finalY1 = (float)plan1.GetFinalPosition().GetY();


                //Dibuixo la línia de trajectòria del vol 1
                g.DrawLine(Trajectoria, origenX1, origenY1, finalX1, finalY1);

                //Fem el mateix per al vol 2

                float origenX2 = (float)plan2.GetInitialPosition().GetX();
                float origenY2 = (float)plan2.GetInitialPosition().GetY();
                float finalX2 = (float)plan2.GetFinalPosition().GetX();
                float finalY2 = (float)plan2.GetFinalPosition().GetY();

                g.DrawLine(Trajectoria, origenX2, origenY2, finalX2, finalY2);

                //FASE 7: crear l'elipse al voltant de cada avió

                //Utilitzo el mètode Conflicto creat a FlightPlan 

                bool conflicto = plan1.Conflicto(plan2, distanciaSeguridad);
                Pen elipseSeguretat;

                if (conflicto)
                {
                    elipseSeguretat = new Pen(Color.Red, 1); //si hi ha conflicte, l'elipsi serà de color vermell
                }
                else
                {
                    elipseSeguretat = new Pen(Color.Green, 1); //si no hi ha conflicte, l'elipsi serà de color verd
                }

                float radi = (float)distanciaSeguridad; //el radi de l'elipsi és la distància de seguretat
                float diametre = radi * 2f;

                //centre de l'elipsi = centre del PictureBox de l'avió, que es calcula com la posició del PictureBox més la meitat de l'amplada i l'alçada del PictureBox
                float x1 = (float)pbAvion1.Location.X + (pbAvion1.Width / 2f);
                float y1 = (float)pbAvion1.Location.Y + (pbAvion1.Height / 2f);

                float x2 = (float)pbAvion2.Location.X + (pbAvion2.Width / 2f);
                float y2 = (float)pbAvion2.Location.Y + (pbAvion2.Height / 2f);

                //Dibuixem l'elipsi al voltant de cada avió, passant les coordenades del centre de l'elipsi i el diàmetre
                g.DrawEllipse(elipseSeguretat, x1 - radi, y1 - radi, diametre, diametre);
                g.DrawEllipse(elipseSeguretat, x2 - radi, y2 - radi, diametre, diametre);

                Trajectoria.Dispose();
                elipseSeguretat.Dispose();

                
                Font fuenteTexto = new Font("Segoe UI", 9, FontStyle.Bold);
                g.DrawString("Vuelo 1", fuenteTexto, Brushes.Black, x1 - 20, y1 - radi - 15);
                g.DrawString("Vuelo 2", fuenteTexto, Brushes.Black, x2 - 20, y2 - radi - 15);
            }
        }
        private void auto_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                timer1.Start();
                estado = 1;
                auto.Text = "Parar";

                panelMap.Invalidate();
                panelMap.Update();

            }
            else
            {
                timer1.Stop();
                estado = 0;
                auto.Text = "Automático";
            }

            //torno a posar l'alarma si hi ha conflicte després de parar o iniciar la simulació automàtica
            if (plan1 != null && plan2 != null)
            {
                bool conflicto = plan1.Conflicto(plan2, distanciaSeguridad);
                if (conflicto)
                {
                    labelAlarma.Text = "ALERTA: Els vols es troben en conflicte!"; //poso l'alarma que avisa si els vols estan en conflicte
                }
                else
                {
                    labelAlarma.Text = "";
                }
            }
            panelMap.Invalidate();
            panelMap.Update();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (plan1 != null)

            {
                plan1.Move(tiempoCiclo);
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX() - (pbAvion1.Width / 2), (int)plan1.GetCurrentPosition().GetY() - (pbAvion1.Height / 2));
                pbAvion1.Tag = plan1;
            }

            if (plan2 != null)
            {
                plan2.Move(tiempoCiclo);
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX() - (pbAvion2.Width / 2), (int)plan2.GetCurrentPosition().GetY() - (pbAvion2.Height / 2));
                pbAvion2.Tag = plan2;
            }

            ComprobarAlarmaConflicto();
            panelMap.Invalidate();
            panelMap.Update();

            bool todosHanLlegado = (plan1 == null || plan1.HasArrived()) && (plan2 == null || plan2.HasArrived());
            if (todosHanLlegado)
            {
                timer1.Stop();
                estado = 0;
                auto.Text = "Automático";
            }
        }

        private void datos_Click(object sender, EventArgs e)
        {
            DatosVueloForm form = new DatosVueloForm(plan1, plan2);
            form.ShowDialog();
        }

        //Botó de predicció de conflicte, que comprova si els vols es trobaran en conflicte en el futur
        private void PrediccionConflicto_Click(object sender, EventArgs e)
        {
            if (plan1 != null && plan2 != null)
            {
                bool conflicto = plan1.PredecirConflicto(plan1, plan2, distanciaSeguridad);
                if (conflicto)
                {
                    MessageBox.Show("Els vols es trobaran en conflicte!");
                }
                else
                {
                    MessageBox.Show("Els vols no es trobaran en conflicte.");
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            estado = 0;
            auto.Text = "Automático";

            plan1.SetCurrentPosition(plan1.GetInitialPosition());
            plan2.SetCurrentPosition(plan2.GetInitialPosition());

            pbAvion1.Location = new Point((int)plan1.GetInitialPosition().GetX() - (pbAvion1.Width / 2), (int)plan1.GetInitialPosition().GetY() - (pbAvion1.Height / 2));
            pbAvion2.Location = new Point((int)plan2.GetInitialPosition().GetX() - (pbAvion2.Width / 2), (int)plan2.GetInitialPosition().GetY() - (pbAvion2.Height / 2));

            HeadingAvio(pbAvion1, plan1, originalImage1);
            HeadingAvio(pbAvion2, plan2, originalImage2);
            
            ComprobarAlarmaConflicto();

            panelMap.Invalidate();
            panelMap.Update();
        }

        private void HeadingAvio(PictureBox pb, FlightPlan plan, Image originalImg)
        {
            if (pb.Image == null || plan == null) return;
           //és la imatge original de l'avió que hi ha al PictureBox

            //Calculo la direcció de l'avió a partir de la posició inicial i final
            double dx = plan.GetFinalPosition().GetX() - plan.GetInitialPosition().GetX();
            double dy = plan.GetFinalPosition().GetY() - plan.GetInitialPosition().GetY();

            //Calculo l'angle de rotació a partir de la direcció
            double heading = Math.Atan2(dy, dx) * (180 / Math.PI); //el 180/Math.PI és per convertir de radians a graus

            Image imagenRotada = RotarAvio(originalImg, (float)heading);

            if (pb.Image != null && pb.Image != originalImg)
            {
                pb.Image.Dispose(); //destrueix imatge antiga
            }

            pb.Image = imagenRotada;

        }

        private Image RotarAvio(Image imgplane, float heading)
        {
            double rad = heading * Math.PI / 180.0;
            double cos = Math.Abs(Math.Cos(rad));
            double sin = Math.Abs(Math.Sin(rad));

            //per no tallar les cantonades
            int newWidth = (int)Math.Ceiling(imgplane.Width * cos + imgplane.Height * sin); //math ceiling es per arrodonir
            int newHeight = (int)Math.Ceiling(imgplane.Width * sin + imgplane.Height * cos);

            Bitmap bmp = new Bitmap(newWidth,newHeight); //creem un bitmap una mica més gran que la imatge original

            using (Graphics g = Graphics.FromImage(bmp)) //creem un objecte gràfic a partir del bitmap
            {
                //activar les propietats de qualitat per a la rotació (que no surti pixelat)
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TranslateTransform(newWidth / 2f, newHeight / 2f); //Movem el punt d'origen al centre de la imatge
                g.RotateTransform(heading); //girem la imatge segons l'angle de rotació
              
                g.DrawImage(imgplane, -imgplane.Width / 2f, -imgplane.Height / 2f); //Dibuixem la imatge original centrada al bitmap amb les transformacions aplicades
            }
            return bmp;
        }



        private void numVelocidad1_ValueChanged(object sender, EventArgs e)
        {
            if (plan1 != null)
            {
                plan1.SetVelocidad((double)numVelocidad1.Value);
                ComprobarAlarmaConflicto();
            }
        }

        private void numVelocidad2_ValueChanged(object sender, EventArgs e)
        {
            if (plan2 != null)
            {
                plan2.SetVelocidad((double)numVelocidad2.Value);
                ComprobarAlarmaConflicto();
            }
        }

        private void panelMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = $"Coordenadas: ({e.X}, {e.Y})";
        }

        private void ComprobarAlarmaConflicto()
        {
            if (plan1 != null && plan2 != null)
            {
                bool conflicto = plan1.Conflicto(plan2, distanciaSeguridad);
                if (conflicto)
                {
                    lblEstadoAlarma.Text = "ALERTA: Conflicto detectado entre vuelos";
                    lblEstadoAlarma.ForeColor = Color.Red;
                }
                else
                {
                    lblEstadoAlarma.Text = "Sin conflictos";
                    lblEstadoAlarma.ForeColor = Color.DarkGreen;
                }
            }
        }
    }
}
 
