using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo.Classes
{
    internal class JogadoresPartida
    {
        private int id;
        private string nome;
        private int pontos;

        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }

        public int Pontos
        {
            get { return pontos; }
            set { this.pontos = value; }
        }
    }
}
