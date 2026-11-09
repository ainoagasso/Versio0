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
        private FlightPlanList listaVuelos;
        private double tiempoCiclo;

        private bool simulacionEnEjecucion = false;

        int estado = 0; // 0 = parado, 1 = en ejecución
        private double distanciaSeguridad;

        public SimulationForm(FlightPlanList lista, double tiempoCiclo, double distanciaSeguridad)
        {
            InitializeComponent();
            this.listaVuelos = lista;
            this.tiempoCiclo = tiempoCiclo;
            this.distanciaSeguridad = distanciaSeguridad;
        }

        private List<PictureBox> aviones = new List<PictureBox>();
        private Image originalImage;
        private void ColocarAviones()
        {
            int i = 0;
            while (i < aviones.Count)
            {
                FlightPlan vuelo = (FlightPlan)aviones[i].Tag;
                int x = (int)vuelo.GetCurrentPosition().GetX() - (aviones[i].Width / 2);
                int y = (int)vuelo.GetCurrentPosition().GetY() - (aviones[i].Height / 2);
                aviones[i].Location = new Point(x, y);
                i++;
            }
        }
        private void SimulationForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            originalImage = Properties.Resources.plane; // (usa el nombre exacto de tu recurso de imagen)

            // Bucle para crear dinámicamente un PictureBox por cada vuelo de la lista
            int i = 0;
            while (i < listaVuelos.DameNum())
            {
                FlightPlan vuelo = listaVuelos.GetFlightPlan(i);

                PictureBox pb = new PictureBox();
                pb.Width = 30;
                pb.Height = 30;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.BackColor = Color.Transparent;
                pb.Image = originalImage;
                pb.Tag = vuelo; // Guarda el vuelo asociado
                pb.Click += new EventHandler(Avion_Click); // Evento al hacer clic

                panelMap.Controls.Add(pb);
                aviones.Add(pb);

                i++;
            }

            ColocarAviones();
        }

        private void Mover_Click(object sender, EventArgs e)
        {
            listaVuelos.Move(tiempoCiclo);
            ColocarAviones();
            ComprobarAlarmaConflicto();
            panelMap.Invalidate();
        }
        private void Avion_Click(object sender, EventArgs e)
        {
            PictureBox pulsado = (PictureBox)sender;
            FlightPlan vuelo = (FlightPlan)pulsado.Tag;

            InformationForm info = new InformationForm(vuelo);
            info.ShowDialog();
        }
        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(panelMap.BackColor);

            Pen penTrayectoria = new Pen(Color.Blue, 2);
            Pen penElipse = new Pen(Color.Green, 2);

            int i = 0;
            while (i < listaVuelos.DameNum())
            {
                FlightPlan vuelo = listaVuelos.GetFlightPlan(i);

                // 1. Dibujar la línea de trayectoria
                float origenX = (float)vuelo.GetInitialPosition().GetX();
                float origenY = (float)vuelo.GetInitialPosition().GetY();
                float finalX = (float)vuelo.GetFinalPosition().GetX();
                float finalY = (float)vuelo.GetFinalPosition().GetY();

                g.DrawLine(penTrayectoria, origenX, origenY, finalX, finalY);

                // 2. Dibujar la elipse de seguridad alrededor de la posición actual
                float radio = (float)distanciaSeguridad;
                float actualX = (float)vuelo.GetCurrentPosition().GetX();
                float actualY = (float)vuelo.GetCurrentPosition().GetY();

                g.DrawEllipse(penElipse, actualX - radio, actualY - radio, radio * 2, radio * 2);

                // 3. Escribir el ID del vuelo encima
                g.DrawString(vuelo.GetId(), this.Font, Brushes.Black, actualX, actualY - 20);

                i++;
            }

            penTrayectoria.Dispose();
            penElipse.Dispose();
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listaVuelos.TodosHanLlegado())
            {
                timer1.Stop();
                MessageBox.Show("Tots els vols han arribat a la seva destinació.");
            }
            else
            {
                listaVuelos.Move(tiempoCiclo);
                ColocarAviones();
                ComprobarAlarmaConflicto();
                panelMap.Invalidate();
            }
        }

        private void datos_Click(object sender, EventArgs e)
        {
            DatosVueloForm form = new DatosVueloForm(listaVuelos); //surt en vermell perquè s'arregla més endavant
            form.ShowDialog();
        }

        //Botó de predicció de conflicte, que comprova si els vols es trobaran en conflicte en el futur
        private void PrediccionConflicto_Click(object sender, EventArgs e)
        {
           // es fa al pas 4
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            estado = 0;
            auto.Text = "Automático";

            listaVuelos.Restart();
            ColocarAviones();
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
       
        private void panelMap_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = "Coordenadas: ({e.X}, {e.Y})";
        }

        private void ComprobarAlarmaConflicto() //es millora al pas 4
        {      
           lblEstadoAlarma.Text = "Sin conflictos";
           lblEstadoAlarma.ForeColor = Color.DarkGreen;
        }
    }
}
 
