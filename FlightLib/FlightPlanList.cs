using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public void Move(double tiempo)
        {
            int i = 0;
            while (i < this.vuelos.Count)
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

        public bool TodosHanLlegado()
        {
            int i = 0;
            while (i < vuelos.Count)
            {
                if (!vuelos[i].HasArrived())
                {
                    return false;
                }
                i++;
            }
            return true;
        }

        public int CargarFichero(string ruta)
        {
            try
            {
                vuelos.Clear();

                using (StreamReader sr = new StreamReader(ruta))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            string[] parts = line.Split(' ');
                            if (parts.Length != 7)
                            {
                                return -2;
                            }
                            string id = parts[0];
                            string company = parts[1];
                            double cpx = Convert.ToDouble(parts[2]);
                            double cpy = Convert.ToDouble(parts[3]);
                            double fpx = Convert.ToDouble(parts[4]);
                            double fpy = Convert.ToDouble(parts[5]);
                            double velocidad = Convert.ToDouble(parts[6]);

                            if (velocidad <= 0)
                            {
                                return -2;
                            }

                            FlightPlan fp = new FlightPlan(id, company, cpx, cpy, fpx, fpy, velocidad);
                            AddFlightPlan(fp);
                        }

                        line = sr.ReadLine();
                    }
                }

                return 0;
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
            catch (FormatException)
            {
                return -2;
            }
            catch (Exception)
            {
                return -2;
            }
        }
        public int GuardarFichero(string ruta)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    int i = 0;
                    while (i < vuelos.Count) 
                    {
                        FlightPlan vuelo = vuelos[i];
                        string linea = vuelo.GetId() + " " + vuelo.GetCompany() + " " + vuelo.GetCurrentPosition().GetX() + " " + vuelo.GetCurrentPosition().GetY() + " " + vuelo.GetFinalPosition().GetX() + " " + vuelo.GetFinalPosition().GetY() + " " + vuelo.GetVelocidad();
                        sw.WriteLine(linea);
                        i++;
                    }
                    if(vuelos.Count == 0)
                    {
                        return -3;
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1;

            }

        }
    }
}
    

