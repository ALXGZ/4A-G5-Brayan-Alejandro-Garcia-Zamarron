using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
	class Animal
	{
		string nombre = "";

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		public Animal()
		{

		}

		public Animal(string nombre)
		{
			this.nombre = nombre;
		}

		public virtual void Despertar()
		{
			Console.WriteLine("El perro "+this.nombre+" se acaba de despertar");
		}

		public virtual void Dormir()
		{
			Console.WriteLine("El perro " + this.nombre + " se acaba de dormir");
		}

		public virtual void Comer()
		{
			Console.WriteLine("El perro " + this.nombre + " se acaba de comer");
		}
	}
}
