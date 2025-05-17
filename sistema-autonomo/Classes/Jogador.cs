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
    public class Jogador
    {
        private int id;
        private string nome;
        private string senha;
        private int pontos;
        private int qtdNaos;

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }
        }
        public int Pontos
        {
            get { return pontos; }
            set { this.pontos = value; }
        }
        public int QtdNaos
        {
            get { return qtdNaos; }
            set { this.qtdNaos = value; }
        }
    }
}
