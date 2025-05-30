﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using sistema_autonomo.Classes;

namespace sistema_autonomo
{
    public partial class Sala : Form
    {
        Tabuleiro tabuleiro = new Tabuleiro();
        Automacao bot = new Automacao();
        List<Personagem> listaDePersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();

        Partida infosDaPartida;
        Jogador infosDoJogador;

        string numeroRodada;
        string verificarVez;
        string[] verificaVezTratado;
        string[] numeroRodadaTratado;

        public Sala(Partida partidaRecebida, Jogador jogadorLocal)
        {
            InitializeComponent();
            infosDaPartida = partidaRecebida;
            infosDoJogador = jogadorLocal;

            infosDaPartida.ListaDeJogadores.Add(infosDoJogador);
            infosDaPartida.ListarJogadores(infosDoJogador);
            infosDaPartida.SetVotosNao();
            lblNomeDoGrupo.Text = infosDaPartida.NomeGrupo;
            lblVersaoDoJogo.Text = Jogo.versao.ToString();

            lblAltNomeJogador1.Text = infosDaPartida.ListaDeJogadores[0].Nome;
            lblAltPontosPlayer1.Text = infosDaPartida.ListaDeJogadores[0].Pontos.ToString();
            lblAltNomeJogador2.Text = infosDaPartida.ListaDeJogadores[1].Nome;
            lblAltPontosPlayer2.Text = infosDaPartida.ListaDeJogadores[1].Pontos.ToString();

            tmrPosicionarPersonagem.Enabled = true;

            //Atribui personagens na lista assim que o programa e executado
            listaDePersonagens = Personagem.ListarPersonagem(0);
            //Adiciona Pictures na instancia do personagem
            Dictionary<string, PictureBox> mapaPersonagens = new Dictionary<string, PictureBox>
            {
                { "Adilson Konrad", picAdilson },
                { "Beatriz Paiva", picBeatriz },
                { "Claro", picClaro },
                { "Douglas Baquiao", picDouglas },
                { "Eduardo Takeo", picTakeo },
                { "Guilherme Rey", picGui },
                { "Heredia", picHeredia },
                { "Kelly Kiyumi", picKelly },
                { "Leonardo Takuno", picLeonardo },
                { "Mario Toledo", picMario },
                { "Quintas", picQuintas },
                { "Ranulfo", picRanulfo },
                { "Toshio", picToshio }
            };
            foreach (var personagem in listaDePersonagens)
            {
                if (mapaPersonagens.ContainsKey(personagem.nome))
                {
                    personagem.cardPersonagem = mapaPersonagens[personagem.nome];
                }
            }

            //Exibir cartas jogador
            string cartasSorteadas = Jogo.ListarCartas(infosDoJogador.Id, infosDoJogador.Senha);
            lstMinhasCartasSala.Items.Clear();
            Dictionary<char, string> mapaCartas = new Dictionary<char, string>
            {
                { 'A', "Adilson Konrad" },
                { 'B', "Beatriz Paiva" },
                { 'C', "Claro" },
                { 'D', "Douglas Baquiao" },
                { 'E', "Eduardo Takeo" },
                { 'G', "Guilherme Rey" },
                { 'H', "Heredia" },
                { 'K', "Kelly Kiyumi" },
                { 'L', "Leonardo Takuno" },
                { 'M', "Mario Toledo" },
                { 'Q', "Quintas" },
                { 'R', "Ranulfo" },
                { 'T', "Toshio" }
            };
            for (int i = 0; i < 6; i++)
            {
                char letra = cartasSorteadas[i];
                if (mapaCartas.ContainsKey(letra))
                {
                    lstMinhasCartasSala.Items.Add(mapaCartas[letra]);
                }
            }

            //Exibir setores da partida
            string listaSetores = Jogo.ListarSetores();
            listaSetores = listaSetores.Replace("\r", "");
            string[] setores = listaSetores.Split('\n');
            for (int i = 0; i < setores.Length - 1; i++)
            {
                lstSetoresSala.Items.Add(setores[i]);
            }
        }
        private void LimparEAtualizarTabuleiro()
        {
            //Faz a limpeza do estado do tabuleiro
            listaDePersonagens = tabuleiro.LimparPosicaoDoPersonagem(listaDePersonagens);
            estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
            //Atualiza o estado do tabuleiro
            estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(infosDaPartida.Id, listaDePersonagens);
            listaDePersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);
        }
        private void btnPosicionar_Click(object sender, EventArgs e)
        {
            if (lstCartas.SelectedItem != null)
            {
                string nomecartaSelecionada = lstCartas.SelectedItem.ToString();
                string NomeRecortado = nomecartaSelecionada.Substring(0, 1);

                if (lstSetoresSala.SelectedItem != null)
                {
                    string nomeSetor = lstSetoresSala.SelectedItem.ToString();
                    int numeroSetorSelecionado = Convert.ToInt32(nomeSetor.Substring(0, 1));
                    //MessageBox.Show(numeroSetorSelecionado.ToString());

                    string retornoColocar = Jogo.ColocarPersonagem(infosDoJogador.Id, infosDoJogador.Senha, numeroSetorSelecionado, NomeRecortado);
                    if (retornoColocar.Substring(0, 4) == "ERRO")
                    {
                        MessageBox.Show(retornoColocar);
                    }
                    else
                    {
                        LimparEAtualizarTabuleiro();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um setor para posicionar!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um personagem para posicionar!");
            }
        }
        // Botão de atualizar tabuleiro
        private void btnAtualizarTabuleiro_Click(object sender, EventArgs e)
        {
            string listaDeVotos = Jogo.ExibirUltimaVotacao(infosDaPartida.Id);
            listaDeVotos.Replace("\r", "");
            listaDeVotos.Split('\n');

            if (listaDeVotos.Substring(0, 1) == "E")
            {
                MessageBox.Show(listaDeVotos);
            }
            else
            {
                for (int i = 0; i < listaDeVotos.Length - 1; i += 3)
                {
                    lstVotacao.Items.Add(listaDeVotos[i].ToString());
                }
            }
        }
        private void PromoverPersonagem(string personagem)
        {
            //Dados recebidos para promover o personagem
            int idJogador = infosDoJogador.Id;
            string senhaJogador = infosDoJogador.Senha;

            Jogo.Promover(idJogador, senhaJogador, personagem);
            LimparEAtualizarTabuleiro();
        }
        private void Votar()
        {
            //Diminui votos todos os jogadores
            string[] ultimasVotacoes = BancoAuxiliar.TratarDados(Jogo.ExibirUltimaVotacao(infosDaPartida.Id));
            string[] infoVotos;
            if (ultimasVotacoes != null)
            {
                for (int i = 0; i < ultimasVotacoes.Length - 1; i++)
            {
                infoVotos = ultimasVotacoes[i].Split(',');
                foreach (Jogador jogador in infosDaPartida.ListaDeJogadores)
                {
                    if (Convert.ToInt32(infoVotos[1]) == jogador.Id)
                    {
                        if (infoVotos[2] == "N")
                        {
                            jogador.QtdNaos--;
                        }
                    }
                }
            }
            }

            string personagemEleitoVotacao;
            List<string> minhasCartas = new List<string>();

            personagemEleitoVotacao = tabuleiro.VerificarPersonagemDaVotacao(); //Personagem do rei

            //minha lista de personagem
            string meusPersonagensRecebidos = Jogo.ListarCartas(infosDoJogador.Id, infosDoJogador.Senha);
            meusPersonagensRecebidos = meusPersonagensRecebidos.Replace("\r\n", "");

            for (int i = 0; i < meusPersonagensRecebidos.Length - 1; i++)
            {
                minhasCartas.Add(meusPersonagensRecebidos.Substring(i, 1));
            }

            if (infosDoJogador.QtdNaos > 0 && !minhasCartas.Contains(personagemEleitoVotacao))
            {
                Jogo.Votar(infosDoJogador.Id, infosDoJogador.Senha, "N");
            }
            else
            {
                Jogo.Votar(infosDoJogador.Id, infosDoJogador.Senha, "S");
            }
            //lblAltQtdNaosJogador1.Text = Convert.ToString(infosDoJogador.QtdNaos);
        }
        private void tmrPosicionarPersonagem_Tick(object sender, EventArgs e)
        {
            tmrPosicionarPersonagem.Enabled = false;
            lblAltQtdNaosJogador1.Text = infosDaPartida.ListaDeJogadores[0].QtdNaos.ToString();
            lblAltQtdNaosJogador2.Text = infosDaPartida.ListaDeJogadores[1].QtdNaos.ToString();

            string rodadaPassada = "0";
            string faseDaPartida = BancoAuxiliar.VerificarFase(infosDaPartida.Id);
            string RodadaAtual = BancoAuxiliar.VerificarRodada(infosDaPartida.Id);
            if (RodadaAtual != rodadaPassada)
            {
                ResetarPosicaoCartas();
                rodadaPassada = RodadaAtual;
            }
            //MessageBox.Show(rodadaPassada.ToString() + " " + RodadaAtual.ToString());

            // Seta a quantidade de cartas 'Não' novamente após entrar em uma nova rodada

            numeroRodada = Jogo.VerificarVez(infosDaPartida.Id);
            numeroRodadaTratado = numeroRodada.Split(',');
            lblAltRodadaPartida.Text = numeroRodadaTratado[2];

            if (Convert.ToInt32(numeroRodadaTratado[2]) > infosDaPartida.VerificadorPartida)
            {
                Console.WriteLine("ENTROUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU");
                infosDaPartida.VerificadorPartida = Convert.ToInt32(numeroRodadaTratado[2]);
                Console.WriteLine(numeroRodadaTratado[2]);
            }

            if (faseDaPartida == "S")
            {
                Personagem personagem = new Personagem();

                int jogadorVez;
                string[] dadosPartida;
                string[] tabuleiroRecebido;

                //Vira metodo
                verificarVez = Jogo.VerificarVez(infosDaPartida.Id);
                verificarVez = verificarVez.Replace("\r", "");
                verificaVezTratado = verificarVez.Split('\n');
                dadosPartida = verificaVezTratado[0].Split(',');
                jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez
                if (verificarVez.Substring(0, 4) != "ERRO")
                {
                    foreach (Jogador j in infosDaPartida.ListaDeJogadores)
                    {
                        Console.WriteLine($"Jogador: {j.Nome}, ID {j.Id}");

                        if (infosDoJogador.Id == jogadorVez)
                        {
                            lblAltStatusVezSala.Text = $"É a sua vez ID {infosDoJogador.Id} - {infosDoJogador.Nome}";
                            break;
                        }
                        if (j.Id == jogadorVez)
                        {
                            lblAltStatusVezSala.Text = $"É a vez do ID {j.Id} - {j.Nome}";
                            break;
                        }
                    }
                }

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
                foreach (Personagem p in listaDePersonagens)
                {
                    if (nomesParaDesposicionar.Contains(p.nome))
                    {
                        p.personagemPosicionado = false;
                    }
                }

                //Faz a limpeza do estado do tabuleiro
                estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
                //Posiciona personagens
                estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(infosDaPartida.Id, listaDePersonagens);
                listaDePersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);

                tabuleiroRecebido = verificarVez.Split('\n');

                lstAltTabuleiroSala.Items.Clear();
                for (int i = 0; i < tabuleiroRecebido.Length - 1; i++)
                {
                    lstAltTabuleiroSala.Items.Add(tabuleiroRecebido[i]);
                }

                lstAltTabuleiroSala.Items.Clear();

                for (int i = 0; i < verificaVezTratado.Length - 1; i++)
                {
                    lstAltTabuleiroSala.Items.Add(verificaVezTratado[i]);
                }

                lstCartas.Items.Clear();
                // Colocando as cartas na lstbox
                for (int i = 0; i < listaDePersonagens.Count; i++)
                {
                    lstCartas.Items.Add(listaDePersonagens[i].nome);
                }

                if (jogadorVez == infosDoJogador.Id)
                {
                    bot.Posicionar(infosDoJogador.Id, infosDoJogador.Senha, infosDaPartida.Id, tabuleiro);
                }
            }
            else if (faseDaPartida == "P")
            {
                LimparEAtualizarTabuleiro();
                string personagemPromover = tabuleiro.VerificarPersonagemMaisAlto();
                PromoverPersonagem(personagemPromover);
            }
            else if (faseDaPartida == "V")
            {
                LimparEAtualizarTabuleiro();
                Votar();
            }

            tmrPosicionarPersonagem.Enabled = true;
        }
        public void ResetarPosicaoCartas()
        {
            Personagem p = new Personagem();
            List<Point> ListaInicial = new List<Point>();
            ListaInicial = p.PointInicial;
            for (int i = 0; i < Personagem.personagenInstanciado.Count(); i++)
            {
                p = Personagem.personagenInstanciado[i];
                p.cardPersonagem.Location = ListaInicial[i];
            }
        }
    }
}