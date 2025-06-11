﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
namespace sistema_autonomo.Classes
{
    public class Tabuleiro
    {
        private const int DISTANCIA_ULTIMA_POSICAO = 3;
        //Partida partidaSelecionada;
        private Dictionary<int, Point> posicoesDeCadaSetor; // Mapeia setores para coordenadas X:Y
        private Dictionary<int, bool> estadoDasPosicoesDoSetor = new Dictionary<int, bool>
            { //TALVEZ POSSA SER UM FOR, MAS VERIFICAR MAIS PARA FRENTE, POIS DESSA FORMA ESTA VISIVELMENTE MELHOR
                { 25, false },   // 6º
                { 21, false }, { 22, false }, { 23, false }, { 24, false },  // 5º
                { 17, false }, { 18, false }, { 19, false }, { 20, false },  // 4º
                { 13, false }, { 14, false }, { 15, false }, { 16, false },  // 3º
                { 9, false }, { 10, false }, { 11, false }, { 12, false },  // 2º
                { 5, false }, { 6, false }, { 7, false }, { 8, false },  // 1º
                { 1, false }, {  2, false }, {  3, false }, {  4, false }  // 0º
            };
        private Dictionary<int, string> posicaoDosPersonagens = new Dictionary<int, string>
            { //TALVEZ POSSA SER UM FOR, MAS VERIFICAR MAIS PARA FRENTE, POIS DESSA FORMA ESTA VISIVELMENTE MELHOR
                { 25, null },   // 6º
                { 21, null }, { 22, null }, { 23, null }, { 24, null },  // 5º
                { 17, null }, { 18, null }, { 19, null }, { 20, null },  // 4º
                { 13, null }, { 14, null }, { 15, null }, { 16, null },  // 3º
                { 9, null }, { 10, null }, { 11, null }, { 12, null },  // 2º
                { 5, null }, { 6, null }, { 7, null }, { 8, null },  // 1º
                {  1, null }, {  2, null }, {  3, null }, {  4, null }  // 0º
            };
        public Tabuleiro()
        {
            // Mapeamento das coordenadas dos setores
            posicoesDeCadaSetor = new Dictionary<int, Point>
            {
                { 25, new Point(1005, 62) },  // 6º
                { 21, new Point(923, 149) }, { 22, new Point(983, 149) }, { 23, new Point(1043, 149) }, { 24, new Point(1103, 149) },  // 5º
                { 17, new Point(923, 235) }, { 18, new Point(983, 235) }, { 19, new Point(1043, 235) }, { 20, new Point(1103, 235) },  // 4º
                { 13, new Point(923, 315) }, { 14, new Point(983, 315) }, { 15, new Point(1043, 315) }, { 16, new Point(1103, 315) },  // 3º
                { 9, new Point(923, 404) }, { 10, new Point(983, 404) }, { 11, new Point(1043, 404) }, { 12, new Point(1103, 404) },  // 2º
                { 5, new Point(923, 491) }, { 6, new Point(983, 491) }, { 7, new Point(1043, 491) }, { 8, new Point(1103, 491) },  // 1º
                { 1, new Point(923, 572) }, { 2, new Point(983, 572) }, { 3, new Point(1043, 572) }, { 4, new Point(1103, 572) }   // 0º
            };
        }
        public string VerificarPersonagemAdversario(string minhasCartas)
        {
            //int qtdPersonagensNaEstrategia = 0;
            List<string> minhasCartasRecebidas = new List<string>();
            for (int i = 0; i < minhasCartas.Length; i++)
            {
                minhasCartasRecebidas.Add(minhasCartas[i].ToString());
            }

            for (int i = 24; i > 0; i--)
            {
                if (!minhasCartasRecebidas.Contains(posicaoDosPersonagens[i]) && posicaoDosPersonagens[i] != null)
                {
                    Console.WriteLine("carta retornada: " + posicaoDosPersonagens[i]);
                    return posicaoDosPersonagens[i];
                }
            }
            return "ERRO";
        }
        public string VerificarMeuPersonagem(string minhasCartas)
        {
            List<string> minhasCartasRecebidas = new List<string>();
            for (int i = 0; i < minhasCartas.Length; i++)
            {
                minhasCartasRecebidas.Add(minhasCartas[i].ToString());
            }

            for (int i = 1; i < 25; i++)
            {
                if (minhasCartasRecebidas.Contains(posicaoDosPersonagens[i]) && posicaoDosPersonagens[i] != null)
                {
                    Console.WriteLine("carta retornada: " + posicaoDosPersonagens[i]);
                    return posicaoDosPersonagens[i];
                }
            }
            return "ERRO";
        }
        public string PromoverPrimeira()
        {
            string retorno = "";
            for (int i = 24; i >= 1; i--)
            {
                if (posicaoDosPersonagens[i] != null)
                {
                    retorno = posicaoDosPersonagens[i];
                    break;
                }
            }
            return retorno;
        }
        public Point PosicaoDoSetor(int posicaoSetor)
        {
            return posicoesDeCadaSetor[posicaoSetor];
        }
        public bool VerificarSetorDisponivel(int setor)
        {
            int[] primeiraPosicaoSetor = { 5, 9, 13, 17, 21 };

            bool posicaoDisponivel = false;

            if (setor == 10) //Setor do Rei
            {
                return posicaoDisponivel;
            }
            for (int i = primeiraPosicaoSetor[setor - 1]; i <= primeiraPosicaoSetor[setor - 1] + DISTANCIA_ULTIMA_POSICAO; i++)
            {
                posicaoDisponivel = VerificarPosicaoSetorDisponivel(i);
                if (posicaoDisponivel == false)
                {
                    return posicaoDisponivel;
                }
            }
            return posicaoDisponivel;
        }
        public bool VerificarPosicaoSetorDisponivel(int posicaoSetor)
        {
            return estadoDasPosicoesDoSetor[posicaoSetor];
        }
        public List<Personagem> PosicionarPersonagem(Dictionary<int, string> estadoTabuleiro, List<Personagem> personagensRecebidos)
        {
            List<Personagem> personagensPosicionados = personagensRecebidos;
            Point novaPosicaoPersonagem;
            for (int i = 1; i <= 25; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    foreach (var personagem in personagensPosicionados)
                    {
                        if (personagem.nome.Substring(0, 1) == estadoTabuleiro[i].Substring(0, 1))
                        {
                            novaPosicaoPersonagem = PosicaoDoSetor(i);
                            personagem.cardPersonagem.Location = novaPosicaoPersonagem;
                            personagem.personagemPosicionado = true;
                        }
                    }
                }
            }
            return personagensPosicionados;
        }
        public int VerificarPosicaoDisponivelNoSetor(int posicaoSetor)
        {
            int posicaoSetorRecebida = posicaoSetor;
            bool posicaoSetorEstaOcupada = true;
            do
            {
                if (posicaoSetorRecebida <= posicaoSetor + DISTANCIA_ULTIMA_POSICAO)
                {
                    posicaoSetorEstaOcupada = VerificarPosicaoSetorDisponivel(posicaoSetorRecebida);
                    if (posicaoSetorEstaOcupada == true)
                        posicaoSetorRecebida++;
                }
                else
                {
                    break;
                }
            } while (posicaoSetorEstaOcupada == true);
            return posicaoSetorRecebida;
        }
        public void ColocarPersonagemNaPosicaoDoSetor(int posicaoDisponivelNoSetor, string nomePersonagemSelecionado)
        {
            estadoDasPosicoesDoSetor[posicaoDisponivelNoSetor] = true;
            if (posicaoDosPersonagens[posicaoDisponivelNoSetor] == null)
            {
                posicaoDosPersonagens[posicaoDisponivelNoSetor] = nomePersonagemSelecionado;
            }
        }
        public int VerificarPrimeiraPosicaoDoSetor(int setor)
        {
            switch (setor)
            {
                case 0:
                    return 1;
                case 1:
                    return 5;
                case 2:
                    return 9;
                case 3:
                    return 13;
                case 4:
                    return 17;
                case 5:
                    return 21;
                case 10:
                    return 25;
                default:
                    return -1;
            }
        }
        public Dictionary<int, string> AtualizarEstadoTabuleiro(int idPartida, List<Personagem> personagensRecebidos)
        {
            string[] tabuleiroSala = BancoAuxiliar.EstadoDoTabuleiro(idPartida);
            List<Personagem> personagensPosicionados = personagensRecebidos;
            //Percorre todo estado do tabuleiro e atribui os valores
            for (int i = 1; i < tabuleiroSala.Length - 1; i++)
            {
                string[] personagemNoSetor = tabuleiroSala[i].Split(',');
                int setorPersonagemSelecionado = Convert.ToInt32(personagemNoSetor[0]);
                string nomePersonagemSelecionado = personagemNoSetor[1];//Arrumar substring 0,1

                int posicaoDisponivelNoSetor = VerificarPosicaoDisponivelNoSetor(VerificarPrimeiraPosicaoDoSetor(setorPersonagemSelecionado));
                ColocarPersonagemNaPosicaoDoSetor(posicaoDisponivelNoSetor, nomePersonagemSelecionado.Substring(0, 1));
            }
            return posicaoDosPersonagens;
        }
        public Dictionary<int, string> LimparTabuleiro(Dictionary<int, string> estadoTabuleiro)
        {
            Dictionary<int, string> estadoTabuleiroRecebido = estadoTabuleiro;
            //Percorre todas as posições do tabuleiro e transforma em nulo o estado do tabuleiro
            for (int i = 1; i <= 25; i++)
            {
                estadoDasPosicoesDoSetor[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            return estadoTabuleiroRecebido;
        }
        public List<Personagem> DesposicionarPersonagens(List<Personagem> personagensRecebidos)
        {
            List<Personagem> personagensDesposicionados = personagensRecebidos;
            List<string> nomesParaDesposicionar = new List<string>
                {
                    "Adilson Konrad",
                    "Beatriz Paiva",
                    "Claro",
                    "Douglas Baquiao",
                    "Eduardo Takeo",
                    "Guilherme Rey",
                    "Heredia",
                    "Kelly Kiyumi",
                    "Leonardo Takuno",
                    "Mario Toledo",
                    "Quintas",
                    "Ranulfo",
                    "Toshio"
                };
            foreach (Personagem p in personagensDesposicionados)
            {
                if (nomesParaDesposicionar.Contains(p.nome))
                {
                    p.personagemPosicionado = false;
                }
            }
            return personagensDesposicionados;
        }
        public string VerificarPersonagemDaVotacao()
        {
            if (posicaoDosPersonagens[25] != null)
                return posicaoDosPersonagens[25].Substring(0, 1);
            else
                return "Erro!";
        }
    }
}
