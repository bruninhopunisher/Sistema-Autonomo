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
        
        List<JogadorPartida> listaJogadores;
        List<Personagem> listaPersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();

        Partida partida;
        JogadorPartida jogadorPartida;
        JogadorLocal jogadorLocal;

        string numeroRodada;
        string verificarVez;
        string[] verificaVezTratado;
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
            listaPersonagens = tabuleiro.LimparPosicaoDoPersonagem(listaPersonagens);
            estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
            //Atualiza o estado do tabuleiro
            estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(partida.Id, listaPersonagens);
            listaPersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaPersonagens);
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

                    string retornoColocar = Jogo.ColocarPersonagem(jogadorLocal.Id, jogadorLocal.Senha, numeroSetorSelecionado, NomeRecortado);
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
        private void PromoverPersonagem(string personagem)
        {
            //Dados recebidos para promover o personagem
            int idJogador = jogadorLocal.Id;
            string senhaJogador = jogadorLocal.Senha;

            Jogo.Promover(idJogador, senhaJogador, personagem);
            LimparEAtualizarTabuleiro();
        }
        private void Votar()
        {
            //Diminui votos todos os jogadores
            string[] ultimasVotacoes = BancoAuxiliar.TratarDados(Jogo.ExibirUltimaVotacao(partida.Id));
            string[] infoVotos;
            if (ultimasVotacoes != null)
            {
                for (int i = 0; i < ultimasVotacoes.Length - 1; i++)
                {
                    infoVotos = ultimasVotacoes[i].Split(',');
                    foreach (JogadorPartida jogador in partida.ListaJogadoresPartida)
                    {
                        if (Convert.ToInt32(infoVotos[1]) == jogadorLocal.Id)
                        {
                            if (infoVotos[2] == "N")
                            {
                                jogadorLocal.Ponto--;
                            }
                        }
                    }
                }
            }

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

            if (jogadorLocal.Ponto > 0 && !minhasCartas.Contains(personagemEleitoVotacao))
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "N");
            }
            else
            {
                Jogo.Votar(jogadorLocal.Id, jogadorLocal.Senha, "S");
            }
            //lblAltQtdNaosJogador1.Text = Convert.ToString(jogadorPartida.QtdNaos);
        }

        private void AtualizarDataGridView()
        {
            dgvSala.DataSource = partida.ListarJogadores(jogadorLocal.Id);
        }
        private void tmrPosicionarPersonagem_Tick(object sender, EventArgs e)
        {
            tmrPosicionarPersonagem.Enabled = false;
            //lblAltQtdNaosJogador1.Text = partida.ListaJogadoresPartida[0].QtdeNao.ToString();
            //lblAltQtdNaosJogador2.Text = partida.ListaJogadoresPartida[1].QtdeNao.ToString();

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

                int jogadorVez;
                string[] dadosPartida;
                string[] tabuleiroRecebido;

                // Atualiza o DGW
                AtualizarDataGridView();

                //Vira metodo
                verificarVez = Jogo.VerificarVez(partida.Id);
                verificarVez = verificarVez.Replace("\r", "");
                verificaVezTratado = verificarVez.Split('\n');
                dadosPartida = verificaVezTratado[0].Split(',');
                jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez
                //if (verificarVez.Substring(0, 4) != "ERRO")
                //{
                //    foreach (JogadorPartida item in listaJogadores)
                //    {
                //        Console.WriteLine($"Jogador: {item.Nome}, ID {item.Id}");

                //        if (jogadorLocal.Id == jogadorVez)
                //        {
                //            lblAltStatusVezSala.Text = $"É a sua vez ID {jogadorPartida.Id} - {jogadorPartida.Nome}";
                //            break;
                //        }
                //        if (item.Id == jogadorVez)
                //        {
                //            lblAltStatusVezSala.Text = $"É a vez do ID {item.Id} - {item.Nome}";
                //            break;
                //        }
                //    }
                //}

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
                foreach (Personagem p in listaPersonagens)
                {
                    if (nomesParaDesposicionar.Contains(p.nome))
                    {
                        p.personagemPosicionado = false;
                    }
                }

                //Faz a limpeza do estado do tabuleiro
                estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
                //Posiciona personagens
                estadoDoTabuleiro = tabuleiro.AtualizarEstadoTabuleiro(partida.Id, listaPersonagens);
                listaPersonagens = tabuleiro.PosicionarPersonagem(estadoDoTabuleiro, listaPersonagens);

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
                for (int i = 0; i < listaPersonagens.Count; i++)
                {
                    lstCartas.Items.Add(listaPersonagens[i].nome);
                }

                if (jogadorVez == jogadorLocal.Id)
                {
                    bot.Posicionar(jogadorLocal.Id, jogadorLocal.Senha, partida.Id, tabuleiro);
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