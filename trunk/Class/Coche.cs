using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//lalal
namespace TestClasses.Class
{
    public class Coche:Vehiculo
    {
        private String marca;
        private String modelo;
        private int cv;

        public Coche()
        {
            this.matricula = "Undefined";
            this.marca = "Undefined";
            this.modelo = "Undefined";
            this.cv = -1;
        }

        public Coche(String matricula, String Marca, String Modelo, int CV)
        {
            this.matricula = matricula;
            this.marca = Marca;
            this.modelo = Modelo;
            this.cv = CV;
        }
        public int CV { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public override String ToString()
        {
            return "Coche: "+base.ToString()+ " - " + this.Marca + " - " + this.Modelo+" - "+this.CV;
        }


    }
}
