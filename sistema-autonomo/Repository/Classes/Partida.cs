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

        private List<JogadorPartida> listaJogadoresPartida = new List<JogadorPartida>();
        private List<JogadorLocal> listaJogadoresLocais = new List<JogadorLocal>();

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

        public List<JogadorPartida> ListaJogadoresPartida
        {
            get { return listaJogadoresPartida; }
        }

        //public List<JogadorPartida> ListarJogadores(int idJogadorLocal)
        //{
        //    string[] jogadoresRecebidos = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(id));
        //    string[] dadosJogador;

        //    if (jogadoresRecebidos != null)
        //    {
        //        for (int i = 0; i < jogadoresRecebidos.Length - 1; i++)
        //        {
        //            dadosJogador = jogadoresRecebidos[i].Split(',');
        //            if (Convert.ToInt32(dadosJogador[0]) != idJogadorLocal)
        //            {
        //                listaJogadoresPartida.Add(new JogadorPartida(Convert.ToInt32(dadosJogador[0]), dadosJogador[1], 0, 0));
        //            }
        //        }
        //        return listaJogadoresPartida;
        //    }
        //    return null;
        //}
        public void SetVotosNao()
        {
            foreach (JogadorLocal jogadorLocal in listaJogadoresLocais)
            {
                if (listaJogadoresLocais.Count == 3)
                {
                    jogadorLocal.QtdeNao = 4;
                    Console.WriteLine("Setado 4");
                }
                else if (listaJogadoresLocais.Count == 4)
                {
                    jogadorLocal.QtdeNao = 3;
                    Console.WriteLine("Setado 3");
                }
                else
                {
                    jogadorLocal.QtdeNao = 2;
                    Console.WriteLine("Setado 2");
                }
            }
        }
    }
}
