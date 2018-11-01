using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class tv
    {
        public string forma = "", color = "", modelo = "";
        public double costo = 0.0, tamaño = 0.0;

        public string VerVideos
        {
            get { return this.VerVideos; }
            set { this.VerVideos = value; }
        }

        public string VerInformacion
        {
            get { return this.VerInformacion; }
            set { this.VerInformacion = value; }
        }

        public string NavegarEnInternet
        {
            get { return this.NavegarEnInternet; }
            set { this.NavegarEnInternet = value; }
        }

        public string EscucharMusica
        {
            get { return this.EscucharMusica; }
            set { this.EscucharMusica = value; }
        }

        public string JugarVideojuegos
        {
            get { return this.JugarVideojuegos; }
            set { this.JugarVideojuegos = value; }
        }

        public tv()
        {

        }

        public tv(string calidad, string modelo, string forma, string video, double tamaño)
        {
            this.forma = forma;
            this.color = color;
            this.modelo = modelo;
            this.costo = 0.0;
            this.tamaño = 0.0;
        }
    }
}
