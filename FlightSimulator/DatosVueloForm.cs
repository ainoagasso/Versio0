using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using FlightLib;

namespace FlightSimulator
{
    public partial class DatosVueloForm : Form
    {
        private FlightPlanList listaVuelos;
        public DatosVueloForm(FlightPlanList Vuelos)
        {
            InitializeComponent();
            
                this.listaVuelos = Vuelos;

                tabladatos.Columns.Add("ColID", "Identificador");
                tabladatos.Columns.Add("ColVel", "Velocidad");
                tabladatos.Columns.Add("ColX", "X");
                tabladatos.Columns.Add("ColY", "Y");

            if (this.listaVuelos != null)
            {
                int i = 0;
                while (i < this.listaVuelos.DameNum())
                {
                    FlightPlan plan = this.listaVuelos.GetFlightPlan(i);
                    Position pos = plan.GetCurrentPosition();

                    tabladatos.Rows.Add(plan.GetId(), plan.GetVelocidad(), pos.GetX().ToString("F2"), pos.GetY().ToString("F2"));
                    i++;
                }
            }

        }
    

        

        private void tabladatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= this.listaVuelos.DameNum())
            {
                return;
            }
            FlightPlan seleccionado = this.listaVuelos.GetFlightPlan(e.RowIndex);

            DistanciaForm form = new DistanciaForm(seleccionado, this.listaVuelos);
            form.ShowDialog();
        }

        private void DatosVueloForm_Load(object sender, EventArgs e)
        {

        }
    }
}
