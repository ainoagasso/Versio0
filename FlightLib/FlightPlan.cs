using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition; // posicion inicial
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition= new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        

        // Metodos (Gets y Sets)
        public string GetId()
        { return this.id; }
        public void SetId(string id)
        { this.id = id; }

        public Position GetInitialPosition()
        { return this.initialPosition; }
        public void SetInitialPosition(Position initialPosition)
        { this.initialPosition = initialPosition; }

        public Position GetCurrentPosition()
        { return this.currentPosition; }
        public void SetCurrentPosition(Position currentPosition)
        { this.currentPosition = currentPosition; }

        public Position GetFinalPosition()
        { return this.finalPosition; }
        public void SetFinalPosition(Position finalPosition)
        { this.finalPosition = finalPosition; }

        public double GetVelocidad()
        { return this.velocidad; }

        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad; }

        public void Move(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            if (currentPosition.Distancia(nextPosition) < hipotenusa)
                currentPosition = nextPosition;
            else
                currentPosition = finalPosition;
        }

        public void Restart()
        {
            this.currentPosition = new Position(this.initialPosition.GetX(), this.initialPosition.GetY());
        }
        public bool HasArrived()
        {
            bool resultado = false;
            if (currentPosition == finalPosition)
                resultado = true;
            return resultado;
        }
        public double Distance(FlightPlan plan)
        {
            return this.currentPosition.Distancia(plan.currentPosition);
        }
        public bool Conflicto(FlightPlan b,double distanciaSeguridad)
        {
            bool conflicto = false;
            if (this.currentPosition.Distancia(b.currentPosition) < distanciaSeguridad*2)
                conflicto = true;
            return conflicto;
        }

        public bool PredecirConflicto(FlightPlan a, FlightPlan b, double distanciaSeguridad)
        {
            //obtinc posicions actuals dels dos avions
            double x1 = a.currentPosition.GetX();
            double y1 = a.currentPosition.GetY();
            double x2 = b.currentPosition.GetX();
            double y2 = b.currentPosition.GetY();

            //obtinc posicions inicials dels dos avions
            double xi1 = a.initialPosition.GetX();
            double yi1 = a.initialPosition.GetY();
            double xi2 = b.initialPosition.GetX();
            double yi2 = b.initialPosition.GetY();

            //obtinc posicions finals dels dos avions
            double xf1 = a.finalPosition.GetX();
            double yf1 = a.finalPosition.GetY();
            double xf2 = b.finalPosition.GetX();
            double yf2 = b.finalPosition.GetY();

            //obtinc velocitats dels dos avions
            double hipotenusa1 = Math.Sqrt(Math.Pow((xf1 - xi1), 2) + Math.Pow ((yf1 - yi1), 2));
            double hipotenusa2 = Math.Sqrt(Math.Pow((xf2 - xi2), 2) + Math.Pow((yf2 - yi2), 2));

            double vx1 = ((xf1 - xi1) / hipotenusa1) * a.velocidad;
            double vy1 = ((yf1 - yi1) / hipotenusa1) * a.velocidad;
            double vx2 = ((xf2 - xi2) / hipotenusa2) * b.velocidad;
            double vy2 = ((yf2 - yi2) / hipotenusa2) * b.velocidad;

            //variacions de posició i velocitat
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dvx = vx2 - vx1;
            double dvy = vy2 - vy1;

            //obtinc el temps amb la derivada 
            double numerador = -((dx*dvx) + (dy * dvy));
            double denominador = (dvx * dvx) + (dvy * dvy);
            double t = numerador / denominador;

            if (t >= 0);
            { 
                double x1t = x1 + vx1 * t;
                double y1t = y1 + vy1 * t;
                double x2t = x2 + vx2 * t;
                double y2t = y2 + vy2 * t;

                double distanciaMinima = Math.Sqrt(Math.Pow((x2t - x1t), 2) + Math.Pow((y2t - y1t), 2));

                if (distanciaMinima < distanciaSeguridad)
                    return true;
                else
                    return false;
            }
        }
        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad); //el :F2 es perquè sigui un float amb dos decimals
            Console.WriteLine("Posición actual: ({0:F2},{1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.HasArrived())
                Console.WriteLine("Ha llegado al destino");
            Console.WriteLine("******************************");
        }
    }
}
