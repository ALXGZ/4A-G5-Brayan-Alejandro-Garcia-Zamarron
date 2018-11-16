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

        public string Forma
        {
            get { return this.forma; }
            set { this.forma = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public double Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }
        public double Tamaño
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
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

        public void VerVideos()
        {
            Console.WriteLine("Estoy viendo videos");
        }

        public void VerInformacion()
        {
            Console.WriteLine("Estoy viendo informacion");
        }

        public void NavegarEnInternet()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void EscucharMusica()
        {
            Console.WriteLine("Estoy escuchando musica");
        }

        public void JugarVideoJuegos()
        {
            Console.WriteLine("Estoy jugando");
        }
    }
}
