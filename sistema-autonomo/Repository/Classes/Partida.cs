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
        private List<Jogador> listaJogadores = new List<Jogador>();
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
        public List<Jogador> ListaJogadores
        {
            get { return listaJogadores; }
        }
        public List<Jogador> ListarJogadores(JogadorLocal jogadorLocal)
        {
            string[] jogadoresRecebidos = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(id));
            if (jogadoresRecebidos != null)
            {
                listaJogadores.Add(jogadorLocal);
                for (int i = 0; i < jogadoresRecebidos.Length - 1; i++)
                {
                    string jogador = jogadoresRecebidos[i];
                    string[] dados = jogador.Split(',');
                    if (Convert.ToInt32(dados[0]) != jogadorLocal.Id)
                    {
                        listaJogadores.Add(new JogadorPartida(Convert.ToInt32(dados[0]), dados[1], Convert.ToInt32(dados[2]), 0));
                    }
                }
                return listaJogadores;
            }
            return null;
        }
        public void SetVotosNao()
        {
            foreach (Jogador jogador in listaJogadores)
            {
                if (listaJogadores.Count <= 3)
                {
                    jogador.QtdNao = 4;
                }
                else if (listaJogadores.Count == 4)
                {
                    jogador.QtdNao = 3;
                }
                else
                {
                    jogador.QtdNao = 2;
                }
            }
        }
        public string VerificarNomeJogadorDaVez()
        {
            string[] dadosDaPartida = BancoAuxiliar.TratarDados(Jogo.VerificarVez(this.id));
            string[] dadosDaPartidaTratado = dadosDaPartida[0].Split(',');
            int idJogador = Convert.ToInt32(dadosDaPartidaTratado[0]);
            foreach(Jogador jogador in listaJogadores)
            {
                if(jogador.Id == idJogador)
                {
                    return jogador.Nome;
                }
            }
            return null;
        }
    }
}
