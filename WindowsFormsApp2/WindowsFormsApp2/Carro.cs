using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Carro
    {
        string forma = "", color = "", tamaño = "", material = "", modelo = "";

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

        public string Tamaño
        {
            get { return this.tamaño; }
            set { this.tamaño = value; }
        }

        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public carro()
        {

        }

        public carro(string color, string tamaño, string velocidad, string modelo, double peso)
        {
            this.forma = forma;
            this.color = color;
            this.tamaño = tamaño;
            this.material = material;
            this.modelo = modelo;
        }

        public void Viajar()
        {
            Console.WriteLine("Estoy viajando");
        }

        public void EscucharMusica()
        {
            Console.WriteLine("Escuchar musica");
        }

        public void Transportar()
        {
            Console.WriteLine("Transportar objetos");
        }

        public void Cubrir()
        {
            Console.WriteLine("Estoy cubierto");
        }

        public void Socializar()
        {
            Console.WriteLine("Estoy socializando");
        }
    }
}
