using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClasses.Class
{
    public class Barco : Vehiculo
    {
        private Double _eslora;
        private Double _calado;
        private Double _manga;

        public Barco()
        {
            this.Matricula = "Undefined";
            this.Eslora = -1.0;
            this.Calado = -1.0;
            this.Manga = -1.0;
        }

        public Barco(String Matricula, Double Eslora, Double Calado, Double manga)
        {
            this.Matricula = Matricula;
            this.Eslora = Eslora;
            this.Calado = Calado;
            this.Manga=manga;
        }


        public Double Eslora
        {
            get { return _eslora; }
            set { _eslora = value; }
        }

        public Double Manga
        {
            get { return _manga; }
            set { _manga = value; }
        }

        public Double Calado
        {
            get { return _calado; }
            set { _calado = value; }
        }

        public override string ToString()
        {
            return "Barco: " + base.ToString() + " - " + this.Eslora + " - " + this.Calado + " - " + this.Manga;
        }

    }
}
