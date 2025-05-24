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
        public override void Posicionar(int jogador, string senha, int id, Tabuleiro tabuleiroRecebido)
        {
            string[] personagens = BancoAuxiliar.TratarDados(Jogo.ListarPersonagens());
            string cartasDoJogador = Jogo.ListarCartas(jogador, senha);

            string tabuleiro = Jogo.VerificarVez(id);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] tabuleiroTratado;
            tabuleiroTratado = tabuleiro.Split('\n');
            List<string> CartasJogadas = new List<string>();

            for (int i = 1; i < tabuleiroTratado.Length - 1; i++)
            {
                CartasJogadas.Add(tabuleiroTratado[i].Substring(2, 1));
            }

            //posicionar personagens das cartas
            for (int i = 0; i < cartasDoJogador.Length; i++)
            {
                if (!(CartasJogadas.Contains(cartasDoJogador.Substring(i, 1))))
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
            ////Diminui votos todos os jogadores
            //string[] ultimasVotacoes = BancoAuxiliar.TratarDados(Jogo.ExibirUltimaVotacao(partida.Id));
            //string[] infoVotos;
            //if (ultimasVotacoes != null)
            //{
            //    for (int i = 0; i < ultimasVotacoes.Length - 1; i++)
            //    {
            //        infoVotos = ultimasVotacoes[i].Split(',');
            //        foreach (JogadorPartida jogador in partida.ListaJogadoresPartida)
            //        {
            //            if (Convert.ToInt32(infoVotos[1]) == jogadorLocal.Id)
            //            {
            //                if (infoVotos[2] == "N")
            //                {
            //                    jogadorLocal.QtdNao--;
            //                }
            //            }
            //        }
            //    }
            //}

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

            if (jogadorLocal.QtdeNao > 0 && !minhasCartas.Contains(personagemEleitoVotacao))
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
