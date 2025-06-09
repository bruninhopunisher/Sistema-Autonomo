using KingMeServer;
using sistema_autonomo.Classes;
using sistema_autonomo.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sistema_autonomo
{
    public partial class Sala : Form
    {
        private Partida partida;
        private JogadorLocal meuJogador;
        private Label[] lblsNome;
        private Label[] lblsNaos;
        private Label[] lblsPontos;
        private PictureBox[] picsNome;
        private PictureBox[] picsNaos;
        private PictureBox[] picsPontos;
        private PictureBox[] picsMinhasCartas;
        private Dictionary<string, PictureBox> mapaPersonagens;
        private Dictionary<char, string> mapaCartas;
        private string cartasSorteadas;
        private int rodadaPassada;
        private string faseDaPartida;
        public int qtdPersonagensPosicionados = 0;
        private string[] qtdPersonagensRecebida;


        Tabuleiro tabuleiro = new Tabuleiro();
        EstrategiaSimples estrategia = new EstrategiaSimples();

        List<Personagem> listaPersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();


        public Sala(Partida partidaRecebida, JogadorLocal jogadorLocal)
        {
            InitializeComponent();
            mapaCartas = new Dictionary<char, string>
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
            mapaPersonagens = new Dictionary<string, PictureBox>
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
            picsNome = new[] { picNomeJogador1, picNomeJogador2, picNomeJogador3, picNomeJogador4 };
            picsNaos = new[] { picVotosJogador1, picVotosJogador2, picVotosJogador3, picVotosJogador4 };
            picsPontos = new[] { picPontosJogador1, picPontosJogador2, picPontosJogador3, picPontosJogador4 };
            picsMinhasCartas = new[] { picMinhaCarta1, picMinhaCarta2, picMinhaCarta3, picMinhaCarta4, picMinhaCarta5, picMinhaCarta6 };
            lblsNome = new[] { lblAltNomeJogador1, lblAltNomeJogador2, lblAltNomeJogador3, lblAltNomeJogador4 };
            lblsNaos = new[] { lblAltQtdNaosJogador1, lblAltQtdNaosJogador2, lblAltQtdNaosJogador3, lblAltQtdNaosJogador4 };
            lblsPontos = new[] { lblAltPontosJogador1, lblAltPontosJogador2, lblAltPontosJogador3, lblAltPontosJogador4 };
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            meuJogador = jogadorLocal;
            partida = partidaRecebida;
            partida.ListarJogadores(jogadorLocal);
            partida.SetQtdVotoNao();
            faseDaPartida = "";
            rodadaPassada = 0;
            qtdPersonagensPosicionados = 13;

            //VER COM O CAUA A LISTA
            listaPersonagens = Personagem.ListarPersonagem(0);
            foreach (var personagem in listaPersonagens)
            {
                if (mapaPersonagens.ContainsKey(personagem.nome))
                {
                    personagem.cardPersonagem = mapaPersonagens[personagem.nome];
                }
            }

            qtdPersonagensRecebida = new string[15];
            AtualizarInfoDaTela();
            tmrVerificarVez.Enabled = true;
        }
        public void AtualizarInfoDaTela()
        {
            //NÃO MEXER NESTE IF PELO AMOR
            if (qtdPersonagensPosicionados > (qtdPersonagensRecebida.Length - 2))
            {
                partida.AtualizarVoto();
                qtdPersonagensPosicionados--;
            }
            //ATE AQUI

            partida.AtualizarPontuacao();
            for (int i = 0; i < partida.ListaJogadores.Count; i++)
            {
                lblsNome[i].Visible = true;
                lblsNaos[i].Visible = true;
                lblsPontos[i].Visible = true;
                picsNome[i].Visible = true;
                picsNaos[i].Visible = true;
                picsPontos[i].Visible = true;
                lblsNome[i].Text = partida.ListaJogadores[i].Nome;
                lblsNaos[i].Text = partida.ListaJogadores[i].QtdNao.ToString();
                lblsPontos[i].Text = partida.ListaJogadores[i].QtdPonto.ToString();
            }
            lblAltStatusVezSala.Text = partida.VerificarNomeJogadorDaVez();
            lblAltRodadaPartida.Text = partida.Rodada.ToString();
            if (faseDaPartida == "S")
            {
                lblAltFasePartida.Text = "Posicionar";
            }
            else if (faseDaPartida == "P")
            {
                lblAltFasePartida.Text = "Promoção";
            }
            else
            {
                lblAltFasePartida.Text = "Votação";
            }
            LimparEAtualizarTabuleiro();
        }
        private void LimparEAtualizarTabuleiro()
        {
            listaPersonagens = tabuleiro.DesposicionarPersonagens(listaPersonagens);
            estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
            estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(partida.Id, listaPersonagens);
            listaPersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaPersonagens);
        }
        public void ResetarPosicaoCartas()
        {
            Personagem p = new Personagem();
            for (int i = 0; i < Personagem.personagenInstanciado.Count(); i++)
            {
                p = Personagem.personagenInstanciado[i];
                p.cardPersonagem.Location = p.PointPersonagens[i];
                p.cardPersonagem.Visible = true;
            }
        }
        private void Jogar()
        {
            LimparEAtualizarTabuleiro();
            if (faseDaPartida == "S") //Em posicionar
            {
                partida.Rodada = Convert.ToInt32(BancoAuxiliar.VerificarRodada(partida.Id));
                estrategia.Posicionar(meuJogador.Id, meuJogador.Senha, partida.Id, tabuleiro);
            }
            else if (faseDaPartida == "P") //Em promoçao
            {
                estrategia.Promover(meuJogador, tabuleiro, cartasSorteadas.Replace("\r\n", ""));
                qtdPersonagensRecebida = BancoAuxiliar.TratarDados(Jogo.VerificarVez(partida.Id));
            }
            else if (faseDaPartida == "V") //Em votação
            {
                estrategia.Votar(tabuleiro, meuJogador);
                qtdPersonagensPosicionados = qtdPersonagensRecebida.Length - 2;
            }
        }

        private void tmrVerificarVez_Tick(object sender, EventArgs e)
        {
            faseDaPartida = BancoAuxiliar.VerificarFase(partida.Id);
            if (faseDaPartida != null && partida.Rodada != rodadaPassada)
            {

                estrategia.SetQtdVotacoes(0);
                rodadaPassada = partida.Rodada;
                ResetarPosicaoCartas();
                partida.SetQtdVotoNao();
                qtdPersonagensPosicionados = 13;
                qtdPersonagensRecebida = new string[15];
                //Atualiza as cartas do jogador
                cartasSorteadas = Jogo.ListarCartas(meuJogador.Id, meuJogador.Senha);
                for (int i = 0; i < 6; i++)
                {
                    char letra = cartasSorteadas[i];
                    if (mapaCartas.ContainsKey(letra))
                    {
                        picsMinhasCartas[i].Image = mapaPersonagens[mapaCartas[letra]].Image;
                    }
                }
            }
            else if (faseDaPartida == "E")
            {
                this.Hide();
                Final final = new Final(partida);
                tmrVerificarVez.Enabled = false;
                final.ShowDialog();
                this.Close();
            }
            string jogadorDaVez = partida.VerificarNomeJogadorDaVez();
            if (jogadorDaVez == meuJogador.Nome)
            {
                Jogar();
            }
            AtualizarInfoDaTela();
        }
    }
}
