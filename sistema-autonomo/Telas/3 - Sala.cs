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
        EstrategiaSimples estrategia = new EstrategiaSimples();
        
        List<JogadorPartida> listaJogadores;
        List<Personagem> listaPersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();

        Partida partida;
        JogadorPartida jogadorPartida;
        JogadorLocal jogadorLocal;

        string numeroRodada;
        string[] numeroRodadaTratado;
        public Sala(Partida partidaRecebida, JogadorLocal jogadorLocal)
        {
            InitializeComponent();
            partida = partidaRecebida;

            this.jogadorLocal = jogadorLocal;
            
            partidaRecebida.SetVotosNao();
            lblNomeDoGrupo.Text = partidaRecebida.NomeGrupo;
            lblVersaoDoJogo.Text = Jogo.versao.ToString();

            //lblAltNomeJogador1.Text = partida.ListaJogadoresPartida[0].Nome;
            //lblAltPontosPlayer1.Text = partida.ListaJogadoresPartida[0].Ponto.ToString();
            //lblAltNomeJogador2.Text = partida.ListaJogadoresPartida[1].Nome;
            //lblAltPontosPlayer2.Text = partida.ListaJogadoresPartida[1].Ponto.ToString();

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
            dgvSala.DataSource = partida.ListarJogadores(jogadorLocal.Id);
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
                
                if (nomeJogadorDaVez == jogadorLocal.Nome)
                {
                    estrategia.Posicionar(jogadorLocal.Id, jogadorLocal.Senha, partida.Id, tabuleiro);
                }
            }
            else if (faseDaPartida == "P")
            {
                string personagemPromover = tabuleiro.VerificarPersonagemMaisAlto();
                estrategia.Promover(personagemPromover, jogadorLocal);
                LimparEAtualizarTabuleiro();
            }
            else if (faseDaPartida == "V")
            {
                LimparEAtualizarTabuleiro();
                estrategia.Votar(tabuleiro, jogadorLocal);
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