using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo.Classes
{
    public class EstrategiaSimples : Estrategia
    {
        private const int PRIMEIRA_POSICAO_SETOR2 = 9;
        private const int ULTIMA_POSICAO_SETOR3 = 16;
        private const int PRIMEIRA_POSICAO_SETOR1 = 5;
        private const int ULTIMA_POSICAO_SETOR4 = 20;
        public override void Posicionar(int jogador, string senha, int id, Tabuleiro tabuleiroRecebido)
        {
            string[] personagens = BancoAuxiliar.TratarDados(Jogo.ListarPersonagens());
            string cartasDoJogador = Jogo.ListarCartas(jogador, senha);
            cartasDoJogador = cartasDoJogador.Replace("\r\n", "");
            bool posicionouPersonagem = false;
            string tabuleiro = Jogo.VerificarVez(id);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] tabuleiroTratado;
            tabuleiroTratado = tabuleiro.Split('\n');
            List<string> CartasJogadas = new List<string>();

            for (int i = 1; i < tabuleiroTratado.Length - 1; i++)
            {
                CartasJogadas.Add(tabuleiroTratado[i].Substring(2, 1));
            } 

            //posicionar personagens das cartas (Com estrategia)
            for (int i = 0; i < cartasDoJogador.Length; i++)
            {
                if (!(CartasJogadas.Contains(cartasDoJogador.Substring(i, 1))))
                {
                    for(int j = ULTIMA_POSICAO_SETOR3; j >= PRIMEIRA_POSICAO_SETOR2; j--)
                    {
                        if (tabuleiroRecebido.VerificarPosicaoSetorDisponivel(j) == false)
                        {
                            if(j >= 13 && j <= 16)
                                Jogo.ColocarPersonagem(jogador, senha, 3, cartasDoJogador.Substring(i, 1));
                            else
                                Jogo.ColocarPersonagem(jogador, senha, 2, cartasDoJogador.Substring(i, 1));

                            posicionouPersonagem = true;
                            break;
                        }
                    }
                    if(posicionouPersonagem == false)
                    {
                        for(int j = PRIMEIRA_POSICAO_SETOR1; j <= ULTIMA_POSICAO_SETOR4; j++)
                        {
                            if (tabuleiroRecebido.VerificarPosicaoSetorDisponivel(j) == false)
                            {
                                if(j >= 5 && j <= 8)
                                    Jogo.ColocarPersonagem(jogador, senha, 1, cartasDoJogador.Substring(i, 1));
                                else if(j >= 9 && j <= 12)
                                    Jogo.ColocarPersonagem(jogador, senha, 2, cartasDoJogador.Substring(i, 1));
                                else if (j >= 13 && j <= 16)
                                    Jogo.ColocarPersonagem(jogador, senha, 3, cartasDoJogador.Substring(i, 1));
                                else if (j >= 17 && j <= 20)
                                    Jogo.ColocarPersonagem(jogador, senha, 4, cartasDoJogador.Substring(i, 1));
                            }
                        }
                    }
                }
            }

            //posicionar restante dos personagens
            for (int i = 0; i < personagens.Length - 1; i++)
            {
                if (!(CartasJogadas.Contains(personagens[i].Substring(0, 1))))
                {
                    int j = 0;
                    do
                    {
                        j++;
                    }
                    while (tabuleiroRecebido.VerificarSetorDisponivel(j) == true);
                    if (j < 5)
                    {
                        Jogo.ColocarPersonagem(jogador, senha, j, personagens[i].Substring(0, 1));
                    }
                }
            }
        }


        public override void Promover(string personagem, JogadorLocal jogadorLocal)
        {
            //Dados recebidos para promover o personagem
            int idJogador = jogadorLocal.Id;
            string senhaJogador = jogadorLocal.Senha;

            Jogo.Promover(idJogador, senhaJogador, personagem);
        }
        public override void Votar(Tabuleiro tabuleiro, JogadorLocal jogadorLocal)
        {
            string personagemEleitoVotacao;
            List<string> minhasCartas = new List<string>();

            personagemEleitoVotacao = tabuleiro.VerificarPersonagemDaVotacao(); //Personagem do rei

            //minha lista de personagem
            string meusPersonagensRecebidos = Jogo.ListarCartas(jogadorLocal.Id, jogadorLocal.Senha);
            meusPersonagensRecebidos = meusPersonagensRecebidos.Replace("\r\n", "");

            for (int i = 0; i < meusPersonagensRecebidos.Length - 1; i++)
            {
                minhasCartas.Add(meusPersonagensRecebidos.Substring(i, 1));
            }

            if (jogadorLocal.QtdNao > 0 && !minhasCartas.Contains(personagemEleitoVotacao))
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "N");
            }
            else
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "S");
            }
        }

    }
}
