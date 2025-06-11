using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo.Classes
{
    public class JogadorPartida : Jogador
    {
        public JogadorPartida(int id, string nome, int ponto, int qtdeNao) : base(id, nome, ponto, qtdeNao){}
    }
}
