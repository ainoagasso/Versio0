using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace FlightSimulator
{
    public partial class InformationForm : Form
    {
        FlightPlan plan;
        public InformationForm(FlightPlan plan)
        {
            InitializeComponent();
            this.plan = plan;
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            if (plan != null)
            {
                lblId.Text= "ID: " + plan.GetId();
                lblInitialPosition.Text = string.Format("Initial Position: ({0:F2}, {1:F2})", plan.GetInitialPosition().GetX(), plan.GetInitialPosition().GetY());
                lblCurrentPosition.Text = string.Format("Current Position: ({0:F2}, {1:F2})", plan.GetCurrentPosition().GetX(), plan.GetCurrentPosition().GetY());
                lblFinalPosition.Text = string.Format("Final Position: ({0:F2}, {1:F2})", plan.GetFinalPosition().GetX(), plan.GetFinalPosition().GetY());
                lblVelocidad.Text = "Speed: " + plan.GetVelocidad().ToString("F2");
            }

        }
    }
}
