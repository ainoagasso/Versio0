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
        public double distanciaSeguridad = 80;

        public SimulationForm(FlightPlan p1, FlightPlan p2, double tiempoCiclo)
        {
            InitializeComponent();
            this.plan1 = p1;
            this.plan2 = p2;
            this.tiempoCiclo = tiempoCiclo;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (plan1 != null)
            {
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX(), (int)plan1.GetCurrentPosition().GetY());
                pbAvion1.Tag = plan1;
            }

            if (plan2 != null)
            {
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX(), (int)plan2.GetCurrentPosition().GetY());
                pbAvion2.Tag = plan2;
            }

            //estableixo el color de fons dels PictureBox a transparent perquè més tard es vegin les elipses
            pbAvion1.BackColor = Color.Transparent;
            pbAvion2.BackColor = Color.Transparent;


        }

        private void Mover_Click(object sender, EventArgs e)
        {

            if (plan1 != null && !plan1.HasArrived())
            {
                plan1.Move(tiempoCiclo);
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX(), (int)plan1.GetCurrentPosition().GetY());

            }

            // Movem el segon avió amb el temps de cicle rebut de la Fase 2
            if (plan2 != null && !plan2.HasArrived())
            {
                plan2.Move(tiempoCiclo);
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX(), (int)plan2.GetCurrentPosition().GetY());

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

                //centre de l'elipsi = posició de l'avió - radi. perquè el centre de l'elipsi sigui el mateix que el centre del avió
                float x1 = (float)pbAvion1.Location.X + (pbAvion1.Width / 2f);
                float y1 = (float)pbAvion1.Location.Y + (pbAvion1.Height / 2f);

                float x2 = (float)pbAvion2.Location.X + (pbAvion2.Width / 2f);
                float y2 = (float)pbAvion2.Location.Y + (pbAvion2.Height / 2f);

                //Dibuixem l'elipsi al voltant de cada avió, passant les coordenades del centre de l'elipsi i el diàmetre
                g.DrawEllipse(elipseSeguretat, x1 - radi, y1 - radi, diametre, diametre);
                g.DrawEllipse(elipseSeguretat, x2 - radi, y2 - radi, diametre, diametre);

                Trajectoria.Dispose();
                elipseSeguretat.Dispose();
            }
        }
        private void auto_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                timer1.Start();
                estado = 1;
                auto.Text = "Parar";
            }
            else
            {
                timer1.Stop();
                estado = 0;
                auto.Text = "Automático";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (plan1 != null)

            {
                plan1.Move(tiempoCiclo);
                pbAvion1.Location = new Point((int)plan1.GetCurrentPosition().GetX(), (int)plan1.GetCurrentPosition().GetY());
                pbAvion1.Tag = plan1;
            }

            if (plan2 != null)
            {
                plan2.Move(tiempoCiclo);
                pbAvion2.Location = new Point((int)plan2.GetCurrentPosition().GetX(), (int)plan2.GetCurrentPosition().GetY());
                pbAvion2.Tag = plan2;
            }
            bool todosHanLlegado = (plan1 == null || plan1.HasArrived()) && (plan2 == null || plan2.HasArrived());
            if (todosHanLlegado)
            {
                timer1.Stop();
                estado = 0;
                auto.Text = "Automático";
            }
        }
    }
}
 
