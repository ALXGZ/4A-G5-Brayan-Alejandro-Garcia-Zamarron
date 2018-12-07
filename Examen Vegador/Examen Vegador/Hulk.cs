using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Vegador
{
    class Hulk: Vengador
    {
        public virtual void UsarEquipamiento()
        {
            Console.WriteLine(this.Nombre + " No tiene equipamiento");
        }
    }
}
