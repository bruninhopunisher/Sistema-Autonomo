using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using sistema_autonomo.Classes;

namespace sistema_autonomo
{
    public class JogadorLocal : Jogador
    {
        private string senha;
        private int qtdeNao;

        public JogadorLocal(int id, string nome, string senha, int ponto, int qtdeNao) : base(id, nome, ponto, qtdeNao)
        {
            this.senha = senha;
            this.ponto = ponto;
            this.qtdeNao = qtdeNao;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
        }

        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }
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
