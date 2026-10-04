using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlightLib; // <-- OBLIGATORIO para quitar la línea roja de FlightPlan

namespace FlightSimulator
{
    public partial class FlightForm : Form
    {
        // Los dos objetos de la clase FlightPlan pedidos en la Fase 2
        private FlightPlan plan1;
        private FlightPlan plan2;

        // Variable para controlar si introducimos el vuelo 1 o el vuelo 2
        private int contadorVuelo = 1;

        public FlightForm()
        {
            InitializeComponent();
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Introduce los datos del Vuelo 1";
            btnGuardar.Text = "Siguiente Vuelo";
        }

        public FlightPlan GetPlan1()
        {
            return this.plan1;
        }

        public FlightPlan GetPlan2()
        {
            return this.plan2;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Length == 0)
                {
                    MessageBox.Show("El identificador (ID) no puede estar vacío.");
                    return;
                }

                string id = txtId.Text.Trim();
                double cpx = Convert.ToDouble(txtCpx.Text);
                double cpy = Convert.ToDouble(txtCpy.Text);
                double fpx = Convert.ToDouble(txtFpx.Text);
                double fpy = Convert.ToDouble(txtFpy.Text);
                double vel = Convert.ToDouble(txtVelocidad.Text);


                if (vel <= 0)
                {
                    MessageBox.Show("La velocidad debe ser mayor que 0.");
                    return;
                }


                if (contadorVuelo == 1)
                {
                    this.plan1 = new FlightPlan(id, cpx, cpy, fpx, fpy, vel);

                    contadorVuelo = 2;
                    lblTitulo.Text = "Introduce los datos del Vuelo 2";
                    btnGuardar.Text = "Guardar y Finalizar";

                    LimpiarCajas();
                }
                else if (contadorVuelo == 2)
                {
                    this.plan2 = new FlightPlan(id, cpx, cpy, fpx, fpy, vel);

                    MessageBox.Show("Los dos planes de vuelo se han guardado con éxito.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de introducir números válidos en las coordenadas y en la velocidad.");
            }
        }
        private void LimpiarCajas()
        {
            txtId.Clear();
            txtCpx.Clear();
            txtCpy.Clear();
            txtFpx.Clear();
            txtFpy.Clear();
            txtVelocidad.Clear();
            txtId.Focus();
        }

    }
}