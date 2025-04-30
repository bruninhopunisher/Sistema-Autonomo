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
        public void QuantidadeJogadoresPartida(Jogador jogadorLocal)
        {
            List<int> ids = new List<int>();

            string listaJogadores = Jogo.ListarJogadores(id);
            string[] linhas = listaJogadores.Split('\n');

            // Retorna a quantidade de Id´s (jogadores) na partida
            foreach (string linha in linhas)
            {
                if (!string.IsNullOrWhiteSpace(linha))
                {
                    string[] partes = linha.Split(',');
                    if (partes.Length > 0 && int.TryParse(partes[0], out int id))
                    {
                        ids.Add(id);
                    }
                }
            }

            //Seta a quatidade de cartas Nãos para o jogador local
            if (ids.Count == 3)
            {
                jogadorLocal.SetNao(4);
                Console.WriteLine($"Setado 4");
            }
            else if (ids.Count == 4)
            {
                jogadorLocal.SetNao(3);
                Console.WriteLine($"Setado 3");
            }
            else if (ids.Count == 5)
            {
                jogadorLocal.SetNao(2);
                Console.WriteLine($"Setado 2");
            }
            else
            {
                jogadorLocal.SetNao(2);
                Console.WriteLine($"Setado 2");
            }

            Console.WriteLine(ids);
        }

    }
}
