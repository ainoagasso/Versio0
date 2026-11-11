using FlightLib;
using System.Numerics;

namespace FlightSimulator
{
    public partial class MenuForm : Form
    {
        private FlightPlanList listaVuelos = new FlightPlanList();


        private double distanciaSeguridad = 50;
        private double tiempoCiclo = 10;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void planesDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Ficheros de texto|*.txt";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                int resultado = listaVuelos.CargarFichero(dialogo.FileName);

                if (resultado == 0)
                {
                    MessageBox.Show("Se han cargado " + listaVuelos.DameNum() + " vuelos correctamente.");
                }
                else if (resultado == -1)
                {
                    MessageBox.Show("Error: El fichero no existe.");
                }
                else if (resultado == -2)
                {
                    MessageBox.Show("Error: El formato de los datos es incorrecto.");
                }
                else if (resultado == -3)
                {
                    MessageBox.Show("Error: El fichero está vacío.");
                }
            }
        }

        private void parámetrosDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametrosForm ventanaParam = new ParametrosForm();

            if (ventanaParam.ShowDialog() == DialogResult.OK)
            {

                this.distanciaSeguridad = ventanaParam.GetDistanciaSeguridad();
                this.tiempoCiclo = ventanaParam.GetTiempoCiclo();
            }
        }

        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaVuelos != null && listaVuelos.DameNum() > 0)
            {
                SimulationForm simForm = new SimulationForm(listaVuelos, tiempoCiclo, distanciaSeguridad);
                simForm.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'introduir els plans de vol des del menú!");
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
