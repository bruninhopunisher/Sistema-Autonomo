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
        Partida partidaSelecionada;
        Jogador jogadorSelecionado;
        //Personagem personagem;
        List<Personagem> listaDePersonagens = new List<Personagem>();
        Dictionary<int, string> estadoDoTabuleiro = new Dictionary<int, string>();
        string verificarVez;

        public Sala(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();
            partidaSelecionada = partidaRecebida;
            jogadorSelecionado = jogadorRecebido;
            lblNomeDoGrupo.Text = Lobby.GetNomeGrupo().ToString();
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            
            //Informações do jogador que esta logado
            lblAltNomeJogador.Text = jogadorSelecionado.GetNome();
            lblAltSenhaJogador.Text = jogadorSelecionado.GetSenha();

            //Atribui personagens na lista assim que o programa e executado
            listaDePersonagens = Personagem.ListarPersonagem(0);

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
            estadoDoTabuleiro = tabuleiro.atualizarEstadoTabuleiro(partidaSelecionada.getID(), listaDePersonagens);

            //estadoDoTabuleiro = tabuleiro.LimparTabuleiro(estadoDoTabuleiro);
            //estadoDoTabuleiro = tabuleiro.atualizarEstadoTabuleiro(partidaSelecionada.getID(), listaDePersonagens);
            //listaDePersonagens = tabuleiro.posicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);

            //Exibir cartas jogador
            string cartasSorteadas = Jogo.ListarCartas(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha());
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

        private void btnConstVerificarVez_Click_1(object sender, EventArgs e)
        {
            estadoDoTabuleiro = tabuleiro.atualizarEstadoTabuleiro(partidaSelecionada.getID(), listaDePersonagens);
            listaDePersonagens = tabuleiro.posicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);

            Personagem personagem = new Personagem();
            int indice = 0;
            int idRetornado;
            string nomeRetornado;
            int indiceRecebido = 0;
            verificarVez = Jogo.VerificarVez(partidaSelecionada.getID());

            string dadosJogadores = Jogo.ListarJogadores(partidaSelecionada.getID());
            dadosJogadores = dadosJogadores.Replace("\r", "");
            string[] dadosJogadorestratados = dadosJogadores.Split('\n');

            StructJogador[] structJogadores = new StructJogador[6];

            foreach (string dadosJogadorestratado in dadosJogadorestratados)
            {
                if (string.IsNullOrWhiteSpace(dadosJogadorestratado)) continue;

                string[] valores = dadosJogadorestratado.Split(',');
                if (valores.Length < 3) continue;

                structJogadores[indice].id = valores[0];
                structJogadores[indice].nome = valores[1];
                structJogadores[indice].pontos = valores[2];
                indice++;
            }

            if (verificarVez.Substring(0, 4) != "ERRO")
            {
                verificarVez = verificarVez.Replace("\r", "");
                string[] tabuleiroRecebido = verificarVez.Split('\n');
                lstAltTabuleiroSala.Items.Clear();
                for (int i = 0; i < tabuleiroRecebido.Length - 1; i++)
                {
                    lstAltTabuleiroSala.Items.Add(tabuleiroRecebido[i]);
                }
                string[] dadosPartida = tabuleiroRecebido[0].Split(',');
                int jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez

                for (int i = 0; i < indice; i++)
                {
                    if (Convert.ToInt32(structJogadores[i].id) == jogadorVez)
                    {
                        idRetornado = Convert.ToInt32(structJogadores[i].id);
                        nomeRetornado = structJogadores[i].nome;
                        indiceRecebido = i;
                    }
                }

                if (jogadorSelecionado.GetId() == jogadorVez)
                {
                    lblAltStatusVezSala.Text = $"É a sua vez ID {jogadorSelecionado.GetId()}: {jogadorSelecionado.GetNome()}";
                }
                else
                {
                    lblAltStatusVezSala.Text = $"É a vez do ID {structJogadores[indiceRecebido].id}: {structJogadores[indiceRecebido].nome}";
                }

                //dgvPersonagens.DataSource = Personagem.ListarPersonagem(5);
            }
            else
            {
                MessageBox.Show(verificarVez);
                //Jogo.ColocarPersonagem(jogadorSelecionado.GetId);
            }

            //minhaLista = Personagem.ListarPersonagem(0);
            
            lstCartas.Items.Clear();
            // Colocando as cartas na lstbox
            for (int i = 0; i < listaDePersonagens.Count; i++)
            {
                lstCartas.Items.Add(listaDePersonagens[i].nome);
            }

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
                    MessageBox.Show(numeroSetorSelecionado.ToString());

                    string retornoColocar = Jogo.ColocarPersonagem(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha(), numeroSetorSelecionado, NomeRecortado);
                    if(retornoColocar.Substring(0, 4) == "ERRO")
                    {
                        MessageBox.Show(retornoColocar);
                    }
                    else
                    {
                        //Seta que o personagem nao esta mais posicionado
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

                        estadoDoTabuleiro = tabuleiro.atualizarEstadoTabuleiro(partidaSelecionada.getID(), listaDePersonagens);
                        listaDePersonagens = tabuleiro.posicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);
                    }
                    //Console.WriteLine(retornoColocar);
                    //retornoColocar = retornoColocar.Replace("\r", "");
                    //string[] dadosRetornados = retornoColocar.Split('\n');
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
            verificarVez = Jogo.VerificarVez(partidaSelecionada.getID());

            verificarVez = verificarVez.Replace("\r", "");
            string[] tabuleiro = verificarVez.Split('\n');
            lstAltTabuleiroSala.Items.Clear();
            for (int i = 0; i < tabuleiro.Length - 1; i++)
            {
                lstAltTabuleiroSala.Items.Add(tabuleiro[i]);
            }
        }

        private void btnConstPromoverPersonagem_Click(object sender, EventArgs e)
        {
            //Dados recebidos para promover o personagem
            int idJogador = jogadorSelecionado.GetId();
            string senhaJogador = jogadorSelecionado.GetSenha();
            string cartaSelecionada = lstCartas.SelectedItem.ToString();
            string setorSelecionadoRecebido = lstSetoresSala.SelectedItem.ToString();
            int idSetorSelecionado = Convert.ToInt32(setorSelecionadoRecebido.Substring(0, 1));

            if (tabuleiro.verificarSetorDisponivel(idSetorSelecionado) == true)
            {
                Jogo.Promover(idJogador, senhaJogador, cartaSelecionada.Substring(0,1));
                //Seta que o personagem nao esta mais posicionado
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
                estadoDoTabuleiro = tabuleiro.atualizarEstadoTabuleiro(partidaSelecionada.getID(), listaDePersonagens);
                listaDePersonagens = tabuleiro.posicionarPersonagem(estadoDoTabuleiro, listaDePersonagens);
            }
            else
            {
                MessageBox.Show("ERRO: Posição não disponivel, por favor selecione uma posição válida!");
            }
        }
    }
}