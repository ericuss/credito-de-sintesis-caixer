using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClasses.Class
{
    public class Vehiculo
    {
        protected String matricula;
        public Vehiculo()
        {
        }

        public Vehiculo(String matricula)
        {
            this.matricula = matricula;
        }

        public String Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public override string ToString()
        {
            return this.Matricula;
        }
       
    }
}
