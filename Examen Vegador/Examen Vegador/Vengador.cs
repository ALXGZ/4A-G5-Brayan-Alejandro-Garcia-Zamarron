using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Vegador
{
    class Vengador: IVengador
    {
        string nombre = "", genero = "";
        int edad = 0;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public virtual void Atacar()
        {
            Console.WriteLine(this.nombre + "esta atacando");
        }

        public virtual void UsarEquipamiento()
        {
            Console.WriteLine(this.nombre + "esta utilizando");
        }

        public virtual void ResivirDaño()
        {
            Console.WriteLine(this.nombre + "esta resiviendo daño");
        }

        public virtual void Morir()
        {
            Console.WriteLine(this.nombre + " esta muriendo");
        }

        public Vengador()
        {

        }

        public Vengador(string nombre, string genero, int edad)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.edad = edad;
        }
    }
}
