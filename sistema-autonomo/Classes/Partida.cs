using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace sistema_autonomo.Classes
{
    public class Partida
    {
        private int id;
        private string nome;
        private string senha;
        private string data;
        private string status;
        private int verificadorPartida;
        private List<Jogador> listaDeJogadores = new List<Jogador>();

        public string NomeGrupo { get { return "Estudantes de Bolonha"; } }

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
        public string Data
        {
            get { return data; }
            set { this.data = value; }
        }
        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }
        public int VerificadorPartida
        {
            get { return verificadorPartida; }
            set { this.verificadorPartida = value; }
        }
        public List<Jogador> ListaDeJogadores
        {
            get { return listaDeJogadores; }
        }
        public List<Jogador> ListarJogadores(Jogador jogadorLogado)
        {
            string[] jogadoresRecebidos = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(id));
            string[] dadosJogador;
            if (jogadoresRecebidos != null)
            {
                for (int i = 0; i < jogadoresRecebidos.Length - 1; i++)
                {
                    Jogador jogador = new Jogador();
                    dadosJogador = jogadoresRecebidos[i].Split(',');
                    if (Convert.ToInt32(dadosJogador[0]) != jogadorLogado.Id)
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
        public void SetVotosNao()
        {
            foreach (Jogador jogador in listaDeJogadores)
            {
                if (listaDeJogadores.Count == 3)
                {
                    jogador.QtdNaos = 4;
                    Console.WriteLine("Setado 4");
                }
                else if (listaDeJogadores.Count == 4)
                {
                    jogador.QtdNaos = 3;
                    Console.WriteLine("Setado 3");
                }
                else
                {
                    jogador.QtdNaos = 2;
                    Console.WriteLine("Setado 2");
                }
            }
        }
    }
}
