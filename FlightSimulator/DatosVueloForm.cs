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
    public partial class DatosVueloForm : Form
    {
        FlightPlan plan1;
        FlightPlan plan2;
        public DatosVueloForm(FlightPlan plan1, FlightPlan plan2)
        {
            InitializeComponent();
            this.plan1 = plan1;
            this.plan2 = plan2;

            tabladatos.Columns.Add("ColID", "Identificador");
            tabladatos.Columns.Add("ColVel", "Velocidad");
            tabladatos.Columns.Add("ColX", "X");
            tabladatos.Columns.Add("ColY", "Y");

            Position pos1 = plan1.GetCurrentPosition();
            Position pos2 = plan2.GetCurrentPosition();

            tabladatos.Rows.Add(plan1.GetId(), plan1.GetVelocidad(), pos1.GetX().ToString("F2"), pos1.GetY().ToString("F2"));
            tabladatos.Rows.Add(plan2.GetId(), plan2.GetVelocidad(), pos2.GetX().ToString("F2"), pos2.GetY().ToString("F2"));
        }

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0) //fer click adalt
            {
                return;
            }
            FlightPlan seleccionado;
            FlightPlan otro;
            if (e.RowIndex == 0)
            {
                seleccionado = plan1;
                otro = plan2;
            }
            else
            {
                seleccionado = plan2;
                otro = plan1;
            }
            DistanciaForm form = new DistanciaForm(seleccionado, otro);
            form.ShowDialog();
        }
    }
}
