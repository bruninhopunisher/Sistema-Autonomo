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

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return senha;
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
