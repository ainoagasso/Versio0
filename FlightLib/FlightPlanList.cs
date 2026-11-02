using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        List<FlightPlan> vuelos = new List<FlightPlan>();

        public int DameNum()
        {
            return this.vuelos.Count;
        }

        public int AddFlightPlan(FlightPlan p)
        {
           
            {
                vuelos.Add(p);
                return 0;
            }
        }
        public FlightPlan GetFlightPlan(int i)
        {
            if (i < 0 || i >= this.vuelos.Count)
            {
                return null;
            }
            else
            {
                return vuelos[i];
            }
        }

        //Recorre todos los elementos del vector y llama al método Mover para mover cada uno
        public void Move (double tiempo)
        {
            int i = 0;
            while (i< this.vuelos.Count)
            {
                vuelos[i].Move(tiempo);
                i++;
            }
        }
        // devuelve los vuelos a su posición inicial , para poder volver a simularlos
        public void Restart()
        {
            int i = 0;
            while (i < this.vuelos.Count)
            {
                vuelos[i].Restart();
                i++;
            }
        }


        public void EscribeConsola()
        {
            int i = 0;
            while (i < this.vuelos.Count)
            {
                vuelos[i].EscribeConsola();
                i++;
            }
        }
    }
}
