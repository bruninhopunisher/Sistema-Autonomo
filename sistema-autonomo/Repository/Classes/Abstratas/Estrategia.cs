using sistema_autonomo.Classes;

namespace sistema_autonomo.Repository.Interfaces
{
    public abstract class Estrategia
    {
        public abstract void Posicionar(int jogador, string senha, int id, Tabuleiro tabuleiroRecebido);
        public abstract void Promover(JogadorLocal jogadorLocal, Tabuleiro tabuleiroRecebido, string minhasCartas);
        public abstract void Votar(Tabuleiro tabuleiro, JogadorLocal jogadorLocal);
    }
}
