using System;
using System.Collections.Generic;
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
        private int qtdeNao;

        List<Jogador> listaDeJogadores = new List<Jogador>();

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

        public void SetPontos(int pontos)
        {
            this.pontos = pontos;
        }

        public int GetPontos()
        {
            return pontos;
        }

        public void SetNao(int num)
        {
            this.qtdeNao = num;
        }

        public int GetNao()
        {
            return qtdeNao;
        }

        // 
        public List<Jogador> QTDEJogadoresPartida(int IDPartida)
        {

            string listaJogadores;
            string[] listaDeJogadoresTratados;
            string[] linhasDeJogadores;

            listaJogadores = Jogo.ListarJogadores(IDPartida);
            listaJogadores = listaJogadores.Replace("\r", "");
            listaJogadores = listaJogadores.Replace("\n", "");
            listaDeJogadoresTratados = listaJogadores.Split(',');
            listaJogadores = listaJogadores.Replace("\r", "");
            linhasDeJogadores = listaJogadores.Split('\n');

            for (int i = 0; i < listaDeJogadoresTratados.Length - 1; i += 2)
            {
                Jogador novoJogador = new Jogador();
                novoJogador.id = Convert.ToInt32(listaDeJogadoresTratados[i]);
                novoJogador.nome = listaDeJogadoresTratados[i + 1];
                listaDeJogadores.Add(novoJogador);
            }
            return listaDeJogadores;
        }
    }
}
