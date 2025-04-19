using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using KingMeServer;
using sistema_autonomo.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace sistema_autonomo
{
    public partial class Lobby : Form
    {
        Partida partidaLobby;
        Jogador jogador;       
        public Lobby(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();
            partidaLobby = partidaRecebida;
            jogador = jogadorRecebido;
            btnAtualizarLobby_Click(null, null);
        }
        private void btnAtualizarLobby_Click(object sender, EventArgs e)
        {
            //Preenche os dados da partida no Lobby
            lblIdPartida.Text = partidaLobby.Id.ToString();

            //ATENÇÃO AQUIIIIIIIIIIIII ABAIXO PRECISA MELHORAR
            lblStatusPartida.Text = partidaLobby.Status;//Precisa atualizar o status, mesmo a partida começando permanece como A no lobby
            //ATENÇÃO AQUIIIIIIIIIIIII ACIMA

            lblNomeJogador.Text = jogador.Nome;
            lblConstSenhaJogadorLogado.Text = jogador.Senha;

            //ATENÇÃO AQUIIIIIIIIIIIII ABAIXO PRECISA MELHORAR
            lblNomeDoGrupo.Text = Classes.Lobby.GetNomeGrupo().ToString();//Melhorar e realocar nome do grupo
            //ATENÇÃO AQUIIIIIIIIIIIII ACIMA

            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            //Fim
            //Informações dos jogadores presentes no lobby
            lstJogadoresLobby.Items.Clear();
            string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(partidaLobby.Id));
            if (jogadores == null)//Compara com null devido ao retorno do tratar dados
            {
                lstJogadoresLobby.Items.Add("Erro");
                return;
            }
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadoresLobby.Items.Add(jogadores[i]);
            }
            //Fim
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string listaJogadores;
            string verificacaoInicio;

            verificacaoInicio = Jogo.Iniciar(jogador.Id, jogador.Senha);

            if (verificacaoInicio.Substring(0, 1) != "E" || verificacaoInicio == "ERRO:Partida não está aberta")
            {
                listaJogadores = Jogo.ListarJogadores(partidaLobby.Id);

                partidaLobby.QuantidadeJogadoresPartida(jogador);
                Sala sala = new Sala(partidaLobby, jogador);
                partidaLobby.Status = "Jogando";
                sala.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(verificacaoInicio);
            }
        }
    }
}