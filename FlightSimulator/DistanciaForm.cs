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
        public DistanciaForm(FlightPlan a, FlightPlan b)
        {
            InitializeComponent();
            
        double d= a.GetCurrentPosition().Distancia(b.GetCurrentPosition());
        label1.Text = "Distancia entre " + a.GetId() + " y " + b.GetId() + ": " + d.ToString("F2");
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
