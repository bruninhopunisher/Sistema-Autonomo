using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo.Classes
{
    public abstract class Estrategia
    {
        public abstract void Posicionar(int jogador, string senha, int id, Tabuleiro tabuleiroRecebido);
        public abstract void Promover(string personagem, JogadorLocal jogadorLocal);
        public abstract void Votar(Tabuleiro tabuleiro, JogadorLocal jogadorLocal);
    }
}
