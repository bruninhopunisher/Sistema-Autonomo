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
        protected int pontos;
        protected int qtdDeNao;
        public Jogador(int id, string nome, int ponto, int qtdeNao)
        {
            this.id = id;
            this.nome = nome;
            this.pontos = ponto;
            this.qtdDeNao = qtdeNao;
        }
        public int Id
        {
            get { return this.id; }
        }
        public string Nome
        {
            get { return this.nome; }
        }
        public int Pontos
        {
            get { return this.pontos; }
            set { this.pontos = value; }
        }
        public int QtdDeNao
        {
            get { return this.qtdDeNao; }
            set { this.qtdDeNao = value; }
        }
    }
}
