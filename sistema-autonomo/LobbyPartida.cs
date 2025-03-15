using System;
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
    public partial class LobbyPartida : Form
    {
        public int idJogadorLogado { get; set; }
        Partida partidaSelecionada;
        Jogador jogadorSelecionado;
        public LobbyPartida(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();

            partidaSelecionada = partidaRecebida;
            jogadorSelecionado = jogadorRecebido;
            lblIdJogadorLogado.Text = jogadorSelecionado.GetId().ToString();
            lblSenhaJogadorLogado.Text = jogadorSelecionado.GetSenha().ToString();
            
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string verificacaoInicio = Jogo.Iniciar(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha());
            MessageBox.Show(verificacaoInicio);

            string cartasSorteadas = Jogo.ListarCartas(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha());
            
            partidaSelecionada.setStatus("Jogando");
            lblNomePartida.Text = partidaSelecionada.getNome();
            lblStatusPartida.Text = partidaSelecionada.getStatus();
            lblPontuacao.Text = jogadorSelecionado.GetPontos().ToString();

            if(verificacaoInicio.Substring(0,4) != "ERRO")
            {
                lstCartasSorteadas.Items.Clear();
                for (int i = 0; i < 6; i++)
                {

                    switch (cartasSorteadas.Substring(i, 1))
                    {
                        case "A":
                            lstCartasSorteadas.Items.Add("Adilson Konrad");
                            break;
                        case "B":
                            lstCartasSorteadas.Items.Add("Beatriz Paiva");
                            break;
                        case "C":
                            lstCartasSorteadas.Items.Add("Claro");
                            break;
                        case "D":
                            lstCartasSorteadas.Items.Add("Douglas Baquiao");
                            break;
                        case "E":
                            lstCartasSorteadas.Items.Add("Eduardo Takeo");
                            break;
                        case "G":
                            lstCartasSorteadas.Items.Add("Guilherme Rey");
                            break;
                        case "H":
                            lstCartasSorteadas.Items.Add("Heredia");
                            break;
                        case "K":
                            lstCartasSorteadas.Items.Add("Karin");
                            break;
                        case "L":
                            lstCartasSorteadas.Items.Add("Leonardo Takuno");
                            break;
                        case "M":
                            lstCartasSorteadas.Items.Add("Mario Toledo");
                            break;
                        case "Q":
                            lstCartasSorteadas.Items.Add("Quintas");
                            break;
                        case "R":
                            lstCartasSorteadas.Items.Add("Ranulfo");
                            break;
                        case "T":
                            lstCartasSorteadas.Items.Add("Toshio");
                            break;

                    }
                }

            
            }
        }
    }
}
