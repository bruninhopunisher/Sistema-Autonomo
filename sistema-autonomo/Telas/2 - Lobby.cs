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
        Partida partida;
        JogadorLocal jogadorLocal;       
        public Lobby(Partida partidaRecebida, JogadorLocal jogadorRecebido)
        {
            InitializeComponent();
            partida = partidaRecebida;
            jogadorLocal = jogadorRecebido;
            btnAtualizarLobby_Click(null, null);
        }
        private void btnAtualizarLobby_Click(object sender, EventArgs e)
        {
            //Dados do lobby
            string[] dadosDoLobby = BancoAuxiliar.TratarDados(Jogo.VerificarVez(partida.Id));
            lblIdPartida.Text = partida.Id.ToString();
            partida.Status = (dadosDoLobby == null ? partida.Status : dadosDoLobby[0].Split(',')[1]);
            lblStatusPartida.Text = partida.Status == "Aberta" ? "Aberta" : "Jogando";
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            //Informações dos jogadores presentes no lobby
            lstJogadoresLobby.Items.Clear();
            string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(partida.Id));
            if (jogadores == null)//Compara com null devido ao retorno do tratar dados
            {
                lstJogadoresLobby.Items.Add("Erro ao atualizar lista");
                return;
            }
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadoresLobby.Items.Add(jogadores[i]);
            }
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string verificacaoInicio = Jogo.Iniciar(jogadorLocal.Id, jogadorLocal.Senha);
            if (verificacaoInicio.Substring(0, 1) != "E" || verificacaoInicio == "ERRO:Partida não está aberta")
            {
                partida.Rodada = 1;
                partida.Status = "Jogando";
                this.Hide();
                Sala sala = new Sala(partida, jogadorLocal);
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