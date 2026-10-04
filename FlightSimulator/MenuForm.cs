using FlightLib;

namespace FlightSimulator
{
    public partial class MenuForm : Form
    {
        private FlightPlan Vuelo1;
        private FlightPlan Vuelo2;

        private double distanciaSeguridad;
        private double tiempoCiclo;
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
    }
}
