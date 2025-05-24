using KingMeServer;
using sistema_autonomo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo
{
    internal class Automacao
    {
        public void Posicionar(int jogador, string senha,int id, Tabuleiro tabuleiroRecebido)
        {
            string[] personagens = BancoAuxiliar.TratarDados(Jogo.ListarPersonagens());
            string cartasDoJogador = Jogo.ListarCartas(jogador, senha);

            string tabuleiro = Jogo.VerificarVez(id);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] tabuleiroTratado;
            tabuleiroTratado = tabuleiro.Split('\n');
            List<string> CartasJogadas = new List<string>();
          
            for(int i = 1; i< tabuleiroTratado.Length - 1; i++)
            {
                CartasJogadas.Add(tabuleiroTratado[i].Substring(2, 1));
            }

            //posicionar personagens das cartas
            for (int i = 0; i < cartasDoJogador.Length; i++)
            {
                if(!(CartasJogadas.Contains(cartasDoJogador.Substring(i, 1))))
                {
                    int j = 0;
                    do
                    {
                        j++;
                    }
                    while (tabuleiroRecebido.VerificarSetorDisponivel(j) == true);
                    if (j < 5)
                    {
                        Jogo.ColocarPersonagem(jogador, senha, j, cartasDoJogador.Substring(i, 1));
                    }
                }
            }
            
            //posicionar restante dos personagens
            for(int i = 0; i < personagens.Length - 1; i++)
            {
                if (!(CartasJogadas.Contains(personagens[i].Substring(0, 1))))
                {
                    int j = 0;
                    do
                    {
                        j++;
                    }
                    while(tabuleiroRecebido.VerificarSetorDisponivel(j) == true);
                    if(j < 5)
                    {
                        Jogo.ColocarPersonagem(jogador, senha, j, personagens[i].Substring(0,1));
                    }
                }
            }
        }
    }

}
