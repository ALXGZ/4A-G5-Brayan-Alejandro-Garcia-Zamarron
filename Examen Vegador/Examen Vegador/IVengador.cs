using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Vegador
{
    interface IVengador
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string Genero { get; set; }

        void Atacar();
        void UsarEquipamiento();
        void ResivirDaño();
        void Morir();
    }
}
