using System.Collections.Generic;
using KingMeServer;
using sistema_autonomo.Repository.Interfaces;

namespace sistema_autonomo.Classes
{
    public class EstrategiaSimples : Estrategia
    {
        public int QtdVotacoesOcorridas { get; private set; }
        private string retornoVotacao = "naodeuerro";
        public EstrategiaSimples()
        {
            SetQtdVotacoes(0);
        }
        public void SetQtdVotacoes(int qtdVotacoes)
        {
            QtdVotacoesOcorridas = qtdVotacoes;
        }
        public override void Posicionar(int jogador, string senha, int id, Tabuleiro tabuleiroRecebido)
        {
            int setor;
            bool posicionouPersonagem = false;
            string[] personagens = BancoAuxiliar.TratarDados(Jogo.ListarPersonagens());

            string cartasDoJogador = Jogo.ListarCartas(jogador, senha);
            cartasDoJogador = cartasDoJogador.Replace("\r\n", "");

            string tabuleiro = Jogo.VerificarVez(id);
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] tabuleiroTratado;
            tabuleiroTratado = tabuleiro.Split('\n');

            List<string> CartasJogadas = new List<string>();

            //adiciona personagens que ja foram colocados no tabuleiro na lista
            for (int i = 1; i < tabuleiroTratado.Length - 1; i++)
            {
                CartasJogadas.Add(tabuleiroTratado[i].Substring(2, 1));
            } 

            //posicionar personagens das cartas (Com estrategia)
            for (int i = 0; i < cartasDoJogador.Length; i++)
            {
                if (!(CartasJogadas.Contains(cartasDoJogador.Substring(i, 1))))
                {
                    setor = 3;
                    while (tabuleiroRecebido.VerificarSetorDisponivel(setor) == true && setor > 1)
                    {
                        setor--;
                    }
                    if (setor > 1)
                    {
                        Jogo.ColocarPersonagem(jogador, senha, setor, cartasDoJogador.Substring(i, 1));
                        posicionouPersonagem = true;
                    }
                    if(posicionouPersonagem == false)
                    {
                        setor = 1;
                        while (tabuleiroRecebido.VerificarSetorDisponivel(setor) == true && setor < 5)
                        {
                            setor++;
                        }
                        if (setor < 5)
                        {
                            Jogo.ColocarPersonagem(jogador, senha, setor, cartasDoJogador.Substring(i, 1));
                            posicionouPersonagem = true;
                        }
                    }
                }
            }

            //posicionar restante dos personagens
            if(posicionouPersonagem == false)
            {
                for (int i = 0; i < personagens.Length - 1; i++)
                {
                    if (!(CartasJogadas.Contains(personagens[i].Substring(0, 1))))
                    {
                        setor = 4;
                        while(tabuleiroRecebido.VerificarSetorDisponivel(setor) == true && setor > 0)
                        {
                            setor--;
                        }
                        if(setor > 0)
                        {
                            Jogo.ColocarPersonagem(jogador, senha, setor, personagens[i].Substring(0, 1));
                        }
                    }
                }
            }
        }
        public override void Promover(JogadorLocal jogadorLocal, Tabuleiro tabuleiroRecebido, string minhasCartas)
        {
            //Dados recebidos para promover o personagem
            int idJogador = jogadorLocal.Id;
            string senhaJogador = jogadorLocal.Senha;
            string personagemPromover;
            string retornoServer;

            if (QtdVotacoesOcorridas < 7)
            {
                personagemPromover = tabuleiroRecebido.VerificarPersonagemAdversario(minhasCartas);
            }
            else
            {
                personagemPromover = tabuleiroRecebido.VerificarMeuPersonagem(minhasCartas);
            }

            retornoServer = Jogo.Promover(idJogador, senhaJogador, personagemPromover);
            if(retornoServer.Substring(0,4) == "ERRO")
            {
                personagemPromover = tabuleiroRecebido.PromoverPrimeira();
                Jogo.Promover(idJogador, senhaJogador, personagemPromover);
            }
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

            if (jogadorLocal.QtdNao > 0 && !minhasCartas.Contains(personagemEleitoVotacao) && QtdVotacoesOcorridas > 3)
            {
                retornoVotacao = Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "N");
            }
            else
            {
                QtdVotacoesOcorridas++;
                retornoVotacao = Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "S");
            }
            if(retornoVotacao == "")
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "S");
            }
            else if (retornoVotacao.Substring(0,4) == "ERRO")
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "S");
            }
        }

    }
}