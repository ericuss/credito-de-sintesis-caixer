using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestClasses.Class;
using System.Reflection;
using System.Runtime.Remoting;

namespace TestClasses.Helper
{
    public class Instanciador
    {
        private Assembly assembly;
        public Instanciador()
        {
            assembly = Assembly.GetExecutingAssembly();

        }

        public Coche instanciarCoche(String att)
        {
            ObjectHandle ManipularObjeto =
                AppDomain.CurrentDomain.CreateInstance(assembly.FullName, "TestClasses.Class.Coche");
            Coche tmpCoche = (Coche)ManipularObjeto.Unwrap();
            String[] listAtts = att.Split('-');
            tmpCoche.Matricula = listAtts[0].Trim();
            tmpCoche.Marca = listAtts[1].Trim();
            tmpCoche.Modelo = listAtts[2].Trim();
            tmpCoche.CV = Convert.ToInt32(listAtts[3].Trim());
         

            return tmpCoche;

        }


        public Moto instanciarMoto(String att)
        {
            ObjectHandle ManipularObjeto =
               AppDomain.CurrentDomain.CreateInstance(assembly.FullName, "TestClasses.Class.Moto");
            Moto tmpMoto = (Moto)ManipularObjeto.Unwrap();
            String[] listAtts = att.Split('-');
            tmpMoto.Matricula=listAtts[0].Trim();
            tmpMoto.CC =  Convert.ToInt32(listAtts[1].Trim());
            tmpMoto.Ruedas = Convert.ToInt32(listAtts[2].Trim());
            return tmpMoto;
        }
        public Avion instanciarAvion(String att)
        {
            ObjectHandle ManipularObjeto =
               AppDomain.CurrentDomain.CreateInstance(assembly.FullName, "TestClasses.Class.Avion");
            Avion tmpAvion = (Avion)ManipularObjeto.Unwrap();
            String[] listAtts = att.Split('-');
            tmpAvion.Matricula = listAtts[0].Trim();
            tmpAvion.Compania = listAtts[1].Trim();
            tmpAvion.Motores = Convert.ToInt32(listAtts[2].Trim());
            tmpAvion.Velocidad = Convert.ToDouble(listAtts[3].Trim());

            return tmpAvion;
        }

        public Barco instanciarBarco(String att)
        {
            ObjectHandle ManipularObjeto =
               AppDomain.CurrentDomain.CreateInstance(assembly.FullName, "TestClasses.Class.Barco");
            Barco tmpbarco = (Barco)ManipularObjeto.Unwrap();
            String[] listAtts = att.Split('-');
            tmpbarco.Matricula = listAtts[0].Trim();
            tmpbarco.Eslora = Convert.ToDouble(listAtts[1].Trim());
            tmpbarco.Calado = Convert.ToDouble(listAtts[2].Trim());
            tmpbarco.Manga = Convert.ToDouble(listAtts[3].Trim());

            return tmpbarco;
        }
    }
}
