using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        private string nacionalidad;

        public string Nacionalidad 
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public Persona() { }

        public Persona(string nombre, int edad,string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }

        public override string ToString()
        {
            return Nombre + " - " + Edad + " - " + nacionalidad;
        }

    }
}
