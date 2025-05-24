using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo.Classes
{
    public abstract class Jogador
    {
        protected int id;
        protected string nome;
        protected int ponto;
        protected int qtdeNao;
        public Jogador(int id, string nome, int ponto, int qtdeNao)
        {
            this.id = id;
            this.nome = nome;
            this.ponto = ponto;
            this.qtdeNao = qtdeNao;
        }
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
