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
    public partial class DistanciaForm : Form
    {
        public DistanciaForm(FlightPlan seleccionado, FlightPlanList listaVuelos)
        {
            InitializeComponent();

            label1.Text = "";

            if (listaVuelos != null)
            {
                int i = 0;
                while (i < listaVuelos.DameNum())
                {
                    FlightPlan plan = listaVuelos.GetFlightPlan(i);

                    if (plan != seleccionado)
                    {
                        double distancia = seleccionado.GetCurrentPosition().Distancia(plan.GetCurrentPosition());
                        label1.Text += "Distancia entre " + seleccionado.GetId() + " y " + plan.GetId() + ": " + distancia.ToString("F2") + "\n";
                    }
                    i++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DistanciaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
