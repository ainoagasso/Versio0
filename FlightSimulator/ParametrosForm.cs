using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightSimulator
{
    public partial class ParametrosForm : Form
    {
        private double distanciaSeguridad;
        private double tiempoCiclo;
        public ParametrosForm()
        {
            InitializeComponent();
        }
        public double GetDistanciaSeguridad()
        {
            return this.distanciaSeguridad;
        }

        public double GetTiempoCiclo()
        {
            return this.tiempoCiclo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                double dist = Convert.ToDouble(txtDistancia.Text);
                double tiempo = Convert.ToDouble(txtTiempoCiclo.Text);

                if (dist <= 0)
                {
                    MessageBox.Show("La distancia de seguridad debe ser mayor que 0");
                    return;
                }

                if (tiempo <= 0)
                {
                    MessageBox.Show("El tiempo de ciclo debe ser mayor que 0");
                    return;
                }

                this.distanciaSeguridad = dist;
                this.tiempoCiclo = tiempo;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduce valores numéricos");
            }
        }
    }
}