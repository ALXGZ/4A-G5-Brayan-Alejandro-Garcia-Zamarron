using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class celular
    {
        public string forma = "", modelo = "", color = "", material = "", tamaño = "";

        public string Comunicar
        {
            get { return this.Comunicar; }
            set { this.Comunicar = value; }
        }

        public string VerVideos
        {
            get { return this.VerVideos; }
            set { this.VerVideos = value; }
        }

        public string NavegarEnInternet
        {
            get { return this.NavegarEnInternet; }
            set { this.NavegarEnInternet = value; }
        }

        public string Calcular
        {
            get { return this.Calcular; }
            set { this.Calcular = value; }
        }

        public string TomarFotos
        {
            get { return this.TomarFotos; }
            set { this.TomarFotos = value; }
        }

        public celular()
        {

        }

        public celular(string tamaño, string velocidad, string comodo, string resistencia, double almacenamiento)
        {
            this.forma = forma;
            this.modelo = modelo;
            this.color = color;
            this.material = material;
            this.tamaño = tamaño;
        }
    }
}
