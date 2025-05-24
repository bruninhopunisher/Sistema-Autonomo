using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo.Classes
{
    public class JogadorPartida : Jogador
    {
        public JogadorPartida(int id, string nome, int ponto, int qtdeNao) : base(id, nome, ponto, qtdeNao) { }
        public int Id
        {
            get { return this.id; }
        }
        public string Nome
        {
            get { return this.nome; }
        }
        public int Ponto
        {
            get { return this.ponto; }
            set { this.ponto = value; }
        }
        public int QtdeNao
        {
            get { return this.qtdeNao; }
            set { this.qtdeNao = value; }
        }
    }
}
