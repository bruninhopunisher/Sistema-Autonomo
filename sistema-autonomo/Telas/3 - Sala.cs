using KingMeServer;
using sistema_autonomo.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace sistema_autonomo
{
    public partial class Sala : Form
    {
        Partida partida;
        JogadorLocal meuJogador;



        Tabuleiro tabuleiro = new Tabuleiro();
        EstrategiaSimples estrategia = new EstrategiaSimples();
        
        List<Personagem> listaPersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();


        string numeroRodada;
        string[] numeroRodadaTratado;
        public Sala(Partida partidaRecebida, JogadorLocal jogadorLocal)
        {
            InitializeComponent();
            meuJogador = jogadorLocal;
            partida = partidaRecebida;
            partida.ListarJogadores(jogadorLocal);
            partida.SetVotosNao();
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            //lblAltStatusVezSala.Text = Precisa ajeitar, eu ia mexer mas tive que sair
            lblAltRodadaPartida.Text = partida.VerificadorPartida.ToString();

            lblAltNomeJogador1.Text = partida.ListaDeJogadores[0].Nome;
            lblAltQtdNaosJogador1.Text = partida.ListaDeJogadores[0].QtdDeNao.ToString();
            lblAltPontosJogador1.Text = partida.ListaDeJogadores[0].Pontos.ToString();
            lblAltNomeJogador2.Text = partida.ListaDeJogadores[1].Nome;
            lblAltQtdNaosJogador2.Text = partida.ListaDeJogadores[1].QtdDeNao.ToString();
            lblAltPontosJogador2.Text = partida.ListaDeJogadores[1].Pontos.ToString();
            if(partida.ListaDeJogadores.Count > 2)
            {
                picNomeJogador3.Visible = true;
                picVotosJogador3.Visible = true;
                picPontosJogador3.Visible = true;
                lblAltNomeJogador3.Visible = true;
                lblAltQtdNaosJogador3.Visible = true;
                lblAltPontosJogador3.Visible = true;
                lblAltNomeJogador3.Text = partida.ListaDeJogadores[2].Nome;
                lblAltQtdNaosJogador3.Text = partida.ListaDeJogadores[2].QtdDeNao.ToString();
                lblAltPontosJogador3.Text = partida.ListaDeJogadores[2].Pontos.ToString();
            }
            if (partida.ListaDeJogadores.Count > 3)
            {
                picNomeJogador4.Visible = true;
                picVotosJogador4.Visible = true;
                picPontosJogador4.Visible = true;
                lblAltNomeJogador4.Visible = true;
                lblAltQtdNaosJogador4.Visible = true;
                lblAltPontosJogador4.Visible = true;
                lblAltNomeJogador4.Text = partida.ListaDeJogadores[3].Nome;
                lblAltQtdNaosJogador4.Text = partida.ListaDeJogadores[3].QtdDeNao.ToString();
                lblAltPontosJogador4.Text = partida.ListaDeJogadores[3].Pontos.ToString();
            }
            tmrPosicionarPersonagem.Enabled = true;

            //Atribui personagens na lista assim que o programa e executado
            listaPersonagens = Personagem.ListarPersonagem(0);
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
            foreach (var personagem in listaPersonagens)
            {
                if (mapaPersonagens.ContainsKey(personagem.nome))
                {
                    personagem.cardPersonagem = mapaPersonagens[personagem.nome];
                }
            }

            //Exibir cartas jogador
            string cartasSorteadas = Jogo.ListarCartas(jogadorLocal.Id, jogadorLocal.Senha);
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
        }
        private void LimparEAtualizarTabuleiro()
        {
            listaPersonagens = tabuleiro.DesposicionarPersonagens(listaPersonagens);
            estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
            estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(partida.Id, listaPersonagens);
            listaPersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaPersonagens);
        }
        private void AtualizarDataGridView()
        {
            dgvSala.DataSource = partida.ListaDeJogadores;
        }
        private void tmrPosicionarPersonagem_Tick(object sender, EventArgs e)
        {
            tmrPosicionarPersonagem.Enabled = false;

            string rodadaPassada = "0";
            string faseDaPartida = BancoAuxiliar.VerificarFase(partida.Id);
            string RodadaAtual = BancoAuxiliar.VerificarRodada(partida.Id);
            if (RodadaAtual != rodadaPassada)
            {
                ResetarPosicaoCartas();
                rodadaPassada = RodadaAtual;
            }
            // Seta a quantidade de cartas 'Não' novamente após entrar em uma nova rodada
            numeroRodada = Jogo.VerificarVez(partida.Id);
            numeroRodadaTratado = numeroRodada.Split(',');
            lblAltRodadaPartida.Text = numeroRodadaTratado[2];
            
            // Atualiza o DGW
            AtualizarDataGridView();

            if (Convert.ToInt32(numeroRodadaTratado[2]) > partida.VerificadorPartida)
            {
                Console.WriteLine("ENTROUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU");
                partida.VerificadorPartida = Convert.ToInt32(numeroRodadaTratado[2]);
                partida.SetVotosNao();
                Console.WriteLine(numeroRodadaTratado[2]);
            }

            if (faseDaPartida == "S")
            {
                Personagem personagem = new Personagem();
                string nomeJogadorDaVez = partida.VerificarNomeJogadorDaVez();

                LimparEAtualizarTabuleiro();
                
                if (nomeJogadorDaVez == meuJogador.Nome)
                {
                    estrategia.Posicionar(meuJogador.Id, meuJogador.Senha, partida.Id, tabuleiro);
                }
            }
            else if (faseDaPartida == "P")
            {
                string personagemPromover = tabuleiro.VerificarPersonagemMaisAlto();
                estrategia.Promover(personagemPromover, meuJogador);
                LimparEAtualizarTabuleiro();
            }
            else if (faseDaPartida == "V")
            {
                LimparEAtualizarTabuleiro();
                estrategia.Votar(tabuleiro, meuJogador);
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