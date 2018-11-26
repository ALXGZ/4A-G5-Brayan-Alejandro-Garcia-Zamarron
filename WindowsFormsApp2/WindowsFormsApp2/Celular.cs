using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Celular
    {
        string forma = "", modelo = "", color = "", material = "", tamaño = "";

        public string Forma
        {
            get { return this.forma; }
            set { this.forma = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public string Tamaño
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
        }

        public Celular()
        {

        }

        public Celular(string forma, string modelo, string color, string material, string tamaño)
        {
            this.forma = "Rectangular";
            this.modelo = "Hisense";
            this.color = "Negro";
            this.material = "Plastico";
            this.tamaño = "2 x 3";
        }

        public void Comunicar()
        {
            Console.WriteLine("Estoy comunicado");
        }

        public void VerVideos()
        {
            Console.WriteLine("Ver videos");
        }

        public void NavegarInternet()
        {
            Console.WriteLine("Estoy en internet");
        }

        public void Calcular()
        {
            Console.WriteLine("Estoy calculando");
        }

        public void TomarFotos()
        {
            Console.WriteLine("Estoy tomando fotos");
        }
    }
}
