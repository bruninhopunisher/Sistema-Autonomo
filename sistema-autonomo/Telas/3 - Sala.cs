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
        private Partida partida;
        private JogadorLocal meuJogador;
        private Label[] lblsNome;
        private Label[] lblsNaos;
        private Label[] lblsPontos;
        private PictureBox[] picsNome;
        private PictureBox[] picsNaos;
        private PictureBox[] picsPontos;
        private string rodadaPassada = "0";
        private bool decrementoProcessado;
        private bool autenticarVotacao;


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
            lblsNome = new[] { lblAltNomeJogador1, lblAltNomeJogador2, lblAltNomeJogador3, lblAltNomeJogador4 };
            lblsNaos = new[] { lblAltQtdNaosJogador1, lblAltQtdNaosJogador2, lblAltQtdNaosJogador3, lblAltQtdNaosJogador4 };
            lblsPontos = new[] { lblAltPontosJogador1, lblAltPontosJogador2, lblAltPontosJogador3, lblAltPontosJogador4 };
            picsNome = new[] { picNomeJogador1, picNomeJogador2, picNomeJogador3, picNomeJogador4 };
            picsNaos = new[] { picVotosJogador1, picVotosJogador2, picVotosJogador3, picVotosJogador4 };
            picsPontos = new[] { picPontosJogador1, picPontosJogador2, picPontosJogador3, picPontosJogador4 };
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            decrementoProcessado = false;
            autenticarVotacao = false;
            tmrPosicionarPersonagem.Enabled = true;
            AtualizarInformacoes();


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

        public void AtualizarInformacoes()
        { 
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
                lblAltStatusVezSala.Text = partida.VerificarNomeJogadorDaVez();
                lblAltRodadaPartida.Text = partida.VerificadorPartida.ToString();
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
            dgvSala.DataSource = partida.ListaJogadores;
        }
        private void tmrPosicionarPersonagem_Tick(object sender, EventArgs e)
        {
            tmrPosicionarPersonagem.Enabled = false;
            AtualizarInformacoes();

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
                partida.VerificadorPartida = Convert.ToInt32(numeroRodadaTratado[2]);
                partida.SetVotosNao();
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
                decrementoProcessado = false;
            }
            else if (faseDaPartida == "V")
            {
                LimparEAtualizarTabuleiro();
                estrategia.Votar(tabuleiro, meuJogador);
                autenticarVotacao = true;
            }
            // Diminui votos todos os jogadores
            Console.WriteLine($"autenticarVotacao e {autenticarVotacao.ToString()}");
            Console.WriteLine($"decrementoProcessado e {decrementoProcessado.ToString()}");
            

            //CORRIGIR AQUI, TEM VEZ QUE ESTA DECREMENTANDO 2 VEZES
            if (!decrementoProcessado && autenticarVotacao)
            {
                string[] voto = BancoAuxiliar.TratarDados(Jogo.ExibirUltimaVotacao(partida.Id));
                string[] infoVoto;
                if (voto != null)
                {
                    for (int i = 0; i < voto.Length - 1; i++)
                    {
                        infoVoto = voto[i].Split(',');
                        foreach (Jogador jogador in partida.ListaJogadores)
                        {
                            if (Convert.ToInt32(infoVoto[1]) == jogador.Id)
                            {
                                if (infoVoto[2] == "N")
                                {
                                    jogador.QtdNao--;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Entrou aqui");
                    autenticarVotacao = false;
                    decrementoProcessado = true; // agora sim, evita executar de novo
                }
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