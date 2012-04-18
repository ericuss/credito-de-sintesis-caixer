using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClasses.Class
{
    public class Avion:Vehiculo
    {
        
        public Avion()
        {
            this.Matricula = "Undefined";
            this.Compania = "Undefined";
            this.Motores = -1;
            this.Velocidad = -1.0;
        }

        public Avion(String Matricula, String comania, int Motores, Double Velocidad)
        {
            this.Matricula = Matricula;
            this.Compania = comania;
            this.Motores = _motores;
            this.Velocidad = Velocidad;
        }


        public String Compania{get;set;}
        public int Motores { get; set; }


        public double Velocidad { get; set; }

        public override string ToString()
        {
            return "Avion: " + base.ToString() + " - " + this.Compania + " - " + this.Motores + " - " + this.Velocidad;
        }

    }
}
