using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo.Classes
{
    public abstract class Estrategia
    {
        public abstract void Posicionar();
        public abstract void Promover();
        public abstract void Votar();
    }
}
