using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Persona
    {
        public string nombre = "";
        public string apellido = "";
        public int edad = 0;
        public double estatura = 0;
        public int peso = 0;
        public void cantar()
        {
            Console.WriteLine("1.- Cantar");
        }

        public void respirar()
        {
            Console.WriteLine("2.- Respirar");
        }
        public void saltar()
        {
            Console.WriteLine("3.- Saltar");
        }
        public void caminar()
        {
            Console.WriteLine("4.- Caminar");
        }
        public void escribir()
        {
            Console.WriteLine("5.- Escribir");
        }
    }
    class Laptop
    {
        public string material = "";
        public int cables = 0;
        public int circuitos = 0;
        public string forma = "";
        public string color = "";
        public void trabajar()
        {
            Console.WriteLine("1.- Trabajar");
        }

        public void videojuegos()
        {
            Console.WriteLine("2.- Jugar videojuegos");
        }
        public void guardar()
        {
            Console.WriteLine("3.- Guardar archivos");
        }
        public void ver_vi()
        {
            Console.WriteLine("4.- Ver videos");
        }
        public void red()
        {
            Console.WriteLine("5.- Entrar a internet");
        }
    }
    class Celular
    {
        public string forma = "";
        public string color = "";
        public string modelo = "";
        public string material = "";
        public string tamaño = "3 x 2";
        public void comunicacion()
        {
            Console.WriteLine("1.- Comunicar");
        }

        public void ver_vi()
        {
            Console.WriteLine("2.- Ver videos");
        }
        public void red()
        {
            Console.WriteLine("3.- Entrar a internet");
        }
        public void calcular()
        {
            Console.WriteLine("4.- Calcular");
        }
        public void tomar_fo()
        {
            Console.WriteLine("5.- Tomar fotografia");
        }
    }
    class TV
    {
        public string forma = "";
        public string color = "";
        public int cables = 0;
        public string material = "";
        public string tamaño = "5 x 3";
        public void ver_vi()
        {
            Console.WriteLine("1.- Ver videos");
        }

        public void Ver_inf()
        {
            Console.WriteLine("2.- Ver información");
        }
        public void red()
        {
            Console.WriteLine("3.- Entrar a internet");
        }
        public void musica()
        {
            Console.WriteLine("4.- Escuchar musica");
        }
        public void videojuegos()
        {
            Console.WriteLine("5.- Jugar videojuegos");
        }
    }

    class Carro
    {
        public string forma = "";
        public string color = "";
        public string tamaño = ""  ;
        public string material = "";
        public string modelo = "";
        public void viajar()
        {
            Console.WriteLine("1.- Viajar");
        }

        public void musica()
        {
            Console.WriteLine("2.- Escuchar musica");
        }
        public void trans_obj()
        {
            Console.WriteLine("3.- Transportar objetos");
        }
        public void cubrir()
        {
            Console.WriteLine("4.- Cubrir del exterior");
        }
        public void socializar()
        {
            Console.WriteLine("5.- Socializar");
        }
    }

    class Leon
    {
        public string sexo = "";
        public string salud = "";
        public int edad = 0;
        public double estatura = 0;
        public int peso = 0;
        public void Nutrirce()
        {
            Console.WriteLine("1.- Alimentarce");
        }

        public void Dormir()
        {
            Console.WriteLine("2.- Dormir");
        }
        public void Trepar()
        {
            Console.WriteLine("3.- Trepar");
        }
        public void reproducirce()
        {
            Console.WriteLine("4.- Reprodurcirce");
        }
        public void Respirar()
        {
            Console.WriteLine("5.- Respirar");
        }
    }
}
