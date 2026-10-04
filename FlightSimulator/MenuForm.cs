using FlightLib;
using System.Numerics;

namespace FlightSimulator
{
    public partial class MenuForm : Form
    {
        private FlightPlan Vuelo1;
        private FlightPlan Vuelo2;
        

        private double distanciaSeguridad=50;
        private double tiempoCiclo=10;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void planesDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightForm ventanaVuelos = new FlightForm();

            if (ventanaVuelos.ShowDialog() == DialogResult.OK)
            {
                this.Vuelo1 = ventanaVuelos.GetPlan1();
                this.Vuelo2 = ventanaVuelos.GetPlan2();
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
            if (Vuelo1 != null && Vuelo2 != null)
            {
                SimulationForm simForm = new SimulationForm(Vuelo1, Vuelo2, tiempoCiclo);
                simForm.Show();
            }
            else
            {
                MessageBox.Show("Primer has d'introduir els plans de vol des del menú!");
            }
        }
    }
}
