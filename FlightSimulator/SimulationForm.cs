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

        public SimulationForm(FlightPlan p1, FlightPlan p2, double tiempoCiclo)
        {
            InitializeComponent();
            this.plan1 = p1;
            this.plan2 = p2;
            this.tiempoCiclo = tiempoCiclo;
        }

        private void SimulationForm_Load(object sender, EventArgs e)
        {
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
    }
}
