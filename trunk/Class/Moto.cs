using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClasses.Class
{
    public class Moto:Vehiculo
    {

        private int _ruedas;

        private int _cc;
      
        public int Ruedas

        {
            get { return _ruedas; }
            set { _ruedas = value; }
        }

   

        public int CC
        {
            get { return _cc; }
            set { _cc = value; }
        }


        public Moto()
        {
            this._cc = -1;
            this._ruedas = -1;
        }

        public Moto(int CC, int Ruedas)
        {
            this._cc = CC;
            this._ruedas = Ruedas;
        }

        public override string ToString()
        {
            return "Moto: "+base.ToString()+" - "+this.CC+" - "+this.Ruedas;
        }
    }
}
