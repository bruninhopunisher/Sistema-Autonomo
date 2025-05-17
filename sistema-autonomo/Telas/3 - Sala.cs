using System;
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
            infosDoJogador.ListaDeJogadores.Add(infosDoJogador);
            infosDoJogador.ListarJogadores(infosDaPartida.Id, infosDoJogador);
            lblNomeDoGrupo.Text = infosDaPartida.NomeGrupo;
            lblVersaoDoJogo.Text = Jogo.versao.ToString();



            lblAltNomeJogador1.Text = infosDoJogador.ListaDeJogadores[0].Nome;
            lblAltPontosPlayer1.Text = infosDoJogador.ListaDeJogadores[0].Pontos.ToString();
            lblAltQtdNaosJogador1.Text = infosDoJogador.ListaDeJogadores[0].QtdNaos.ToString();
            lblAltNomeJogador2.Text = infosDoJogador.ListaDeJogadores[1].Nome;
            lblAltPontosPlayer2.Text = infosDoJogador.ListaDeJogadores[1].Pontos.ToString();
            lblAltQtdNaosJogador2.Text = infosDoJogador.ListaDeJogadores[1].QtdNaos.ToString();
            tmrPosicionarPersonagem.Enabled = true;



            // Seta a quantidade de cartas 'Não' novamente após entrar em uma nova rodada
            //numeroRodada = Jogo.VerificarVez(2160);
            //numeroRodadaTratado = numeroRodada.Split(',');
            //if (Convert.ToInt32(numeroRodadaTratado[2]) > partidaRecebida.VerificadorPartida)
            //{
            //    partidaRecebida.VerificadorPartida = Convert.ToInt32(numeroRodadaTratado[2]);
            //    Console.WriteLine(numeroRodadaTratado[2]);
            //    partidaRecebida.QuantidadeJogadoresPartida(jogadorLocal);
            //}


            //Atribui personagens na lista assim que o programa e executado
            listaDePersonagens = sistema_autonomo.Personagem.ListarPersonagem(0);
            //Adiciona Pictures na instancia do personagem
            for (int i = 0; i < listaDePersonagens.Count; i++)
            {
                switch (listaDePersonagens[i].nome)
                {
                    case "Adilson Konrad":
                        listaDePersonagens[i].cardPersonagem = picAdilson;
                        break;
                    case "Beatriz Paiva":
                        listaDePersonagens[i].cardPersonagem = picBeatriz;
                        break;
                    case "Claro":
                        listaDePersonagens[i].cardPersonagem = picClaro;
                        break;
                    case "Douglas Baquiao":
                        listaDePersonagens[i].cardPersonagem = picDouglas;
                        break;
                    case "Eduardo Takeo":
                        listaDePersonagens[i].cardPersonagem = picTakeo;
                        break;
                    case "Guilherme Rey":
                        listaDePersonagens[i].cardPersonagem = picGui;
                        break;
                    case "Heredia":
                        listaDePersonagens[i].cardPersonagem = picHeredia;
                        break;
                    case "Kelly Kiyumi":
                        listaDePersonagens[i].cardPersonagem = picKelly;
                        break;
                    case "Leonardo Takuno":
                        listaDePersonagens[i].cardPersonagem = picLeonardo;
                        break;
                    case "Mario Toledo":
                        listaDePersonagens[i].cardPersonagem = picMario;
                        break;
                    case "Quintas":
                        listaDePersonagens[i].cardPersonagem = picQuintas;
                        break;
                    case "Ranulfo":
                        listaDePersonagens[i].cardPersonagem = picRanulfo;
                        break;
                    case "Toshio":
                        listaDePersonagens[i].cardPersonagem = picToshio;
                        break;
                }
            }

            //Atualiza estado do tabuleiro
            estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(infosDaPartida.Id, listaDePersonagens);

            //Exibir cartas jogador
            string cartasSorteadas = Jogo.ListarCartas(infosDoJogador.Id, infosDoJogador.Senha);
            lstMinhasCartasSala.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                switch (cartasSorteadas.Substring(i, 1))
                {
                    case "A":
                        lstMinhasCartasSala.Items.Add("Adilson Konrad");
                        break;
                    case "B":
                        lstMinhasCartasSala.Items.Add("Beatriz Paiva");
                        break;
                    case "C":
                        lstMinhasCartasSala.Items.Add("Claro");
                        break;
                    case "D":
                        lstMinhasCartasSala.Items.Add("Douglas Baquiao");
                        break;
                    case "E":
                        lstMinhasCartasSala.Items.Add("Eduardo Takeo");
                        break;
                    case "G":
                        lstMinhasCartasSala.Items.Add("Guilherme Rey");
                        break;
                    case "H":
                        lstMinhasCartasSala.Items.Add("Heredia");
                        break;
                    case "K":
                        lstMinhasCartasSala.Items.Add("Kelly Kiyumi");
                        break;
                    case "L":
                        lstMinhasCartasSala.Items.Add("Leonardo Takuno");
                        break;
                    case "M":
                        lstMinhasCartasSala.Items.Add("Mario Toledo");
                        break;
                    case "Q":
                        lstMinhasCartasSala.Items.Add("Quintas");
                        break;
                    case "R":
                        lstMinhasCartasSala.Items.Add("Ranulfo");
                        break;
                    case "T":
                        lstMinhasCartasSala.Items.Add("Toshio");
                        break;
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
            int qtdeVotosNao;
            string personagemEleitoVotacao;
            string retornoDaFuncao;
            List<string> personagensDoJogadorLocal = new List<string>();

            personagemEleitoVotacao = tabuleiro.VerificarPersonagemDaVotacao();
            qtdeVotosNao = infosDoJogador.QtdNaos;

            string meusPersonagensRecebidos = Jogo.ListarCartas(infosDoJogador.Id, infosDoJogador.Senha);
            meusPersonagensRecebidos = meusPersonagensRecebidos.Replace("\r\n", "");

            for (int i = 0; i < meusPersonagensRecebidos.Length - 1; i++)
            {
                personagensDoJogadorLocal.Add(meusPersonagensRecebidos.Substring(i, 1));
            }

            if (qtdeVotosNao > 0 && !personagensDoJogadorLocal.Contains(personagemEleitoVotacao))
            {
                retornoDaFuncao = Jogo.Votar(infosDoJogador.Id, infosDoJogador.Senha, "N");
                //MessageBox.Show(retornoDaFuncao);
                if (retornoDaFuncao.Substring(0, 1) != "E")
                {
                    infosDoJogador.QtdNaos = (qtdeVotosNao - 1);
                }
            }
            else
            {
                Jogo.Votar(infosDoJogador.Id, infosDoJogador.Senha, "S");
            }
            lblAltQtdNaosJogador1.Text = Convert.ToString(infosDoJogador.QtdNaos);
        }
        //aqui
        private void tmrPosicionarPersonagem_Tick(object sender, EventArgs e)
        {
            string rodadaPassada = "0";
            tmrPosicionarPersonagem.Enabled = false;
            string faseDaPartida = BancoAuxiliar.VerificarFase(infosDaPartida.Id);
            string RodadaAtual = BancoAuxiliar.VerificarRodada(infosDaPartida.Id);
            if (RodadaAtual != rodadaPassada)
            {
                ResetarPosicaoCartas();
                rodadaPassada = RodadaAtual;
            }
            //MessageBox.Show(rodadaPassada.ToString() + " " + RodadaAtual.ToString());


            lblAltRodadaPartida.Text = faseDaPartida;

            if (faseDaPartida == "S")
            {
                Personagem personagem = new Personagem();

                int jogadorVez;
                string[] dadosPartida;
                string[] tabuleiroRecebido;

                verificarVez = Jogo.VerificarVez(infosDaPartida.Id);
                verificarVez = verificarVez.Replace("\r", "");
                verificaVezTratado = verificarVez.Split('\n');
                dadosPartida = verificaVezTratado[0].Split(',');
                jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez
                if (verificarVez.Substring(0, 4) != "ERRO")
                {
                    foreach (Jogador j in infosDoJogador.ListaDeJogadores)
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




                for (int i = 0; i < listaDePersonagens.Count; i++)
                {
                    switch (listaDePersonagens[i].nome)
                    {
                        case "Adilson Konrad":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Beatriz Paiva":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Claro":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Douglas Baquiao":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Eduardo Takeo":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Guilherme Rey":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Heredia":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Kelly Kiyumi":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Leonardo Takuno":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Mario Toledo":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Quintas":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Ranulfo":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
                        case "Toshio":
                            listaDePersonagens[i].personagemPosicionado = false;
                            break;
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