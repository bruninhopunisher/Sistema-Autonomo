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
        private List<Jogador> listaDeJogadores = new List<Jogador>();
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
        public List<Jogador> ListaDeJogadores
        {
            get { return listaDeJogadores; }
        }
        public List<Jogador> ListarJogadores(int IdPartida, Jogador jogadorLogado)
        {
            string[] jogadoresRecebidos = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(IdPartida));
            string[] dadosJogador;
            if(jogadoresRecebidos != null)
            {
                for (int i = 0; i < jogadoresRecebidos.Length - 1; i += 2)
                {
                    Jogador jogador = new Jogador();
                    dadosJogador = jogadoresRecebidos[i].Split(',');
                    if(Convert.ToInt32(dadosJogador[0]) != jogadorLogado.id)
                    {
                        jogador.Id = Convert.ToInt32(dadosJogador[0]);
                        jogador.Nome = dadosJogador[1];
                        listaDeJogadores.Add(jogador);
                    }
                }
                return listaDeJogadores;
            }
            return null;
        }
    }
}
