using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
	class Perro: Animal
	{
        public override void Comer()
        {
            base.Comer();
            Console.WriteLine("Mi perro llamado " + this.Nombre + " Ha empezado a comer");
        }

    }
}
