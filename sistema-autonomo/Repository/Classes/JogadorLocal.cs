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
        public JogadorLocal(int id, string nome, string senha, int ponto, int qtdeNao) : base(id, nome, ponto, qtdeNao)
        {
            this.senha = senha;
        }
        public string Senha
        {
            get { return senha; }
        }
    }
}
