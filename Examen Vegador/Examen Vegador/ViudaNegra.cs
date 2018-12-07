using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Vegador
{
    class ViudaNegra: Vengador
    {
        public virtual void UsarEquipamiento()
        {
            Console.WriteLine(this.Nombre + " esta utilizando su pistola");
        }
    }
}
