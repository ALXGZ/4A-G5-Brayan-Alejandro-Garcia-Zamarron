using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class persona
    {
        public string nombre = "", apellido = "";
        public int edad = 0;
        public double peso = 0.0, estatura = 0.0;

        public string Cantar
        {
            get { return this.Cantar; }
            set { this.Cantar = value; }
        }

        public string Respirar
        {
            get { return this.Respirar; }
            set { this.Respirar = value; }
        }

        public string Saltar
        {
            get { return this.Saltar; }
            set { this.Saltar = value; }
        }

        public string Caminar
        {
            get { return this.Caminar; }
            set { this.Caminar = value; }
        }

        public string Escribir
        {
            get { return this.Escribir; }
            set { this.Escribir = value; }
        }

        public persona()
        {

        }

        public persona(string nombre, string apellidos, string sexo, string fechNac, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 0;
            this.peso = 0.0;
            this.estatura = 0.0;
        }
    }
}
