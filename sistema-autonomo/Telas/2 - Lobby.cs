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
        Partida infosDaPartida;
        Jogador jogador;       
        public Lobby(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();
            infosDaPartida = partidaRecebida;
            jogador = jogadorRecebido;
            btnAtualizarLobby_Click(null, null);
        }
        private void btnAtualizarLobby_Click(object sender, EventArgs e)
        {
            //Inicio - Preenche os dados da partida no Lobby
            string[] dadosPartida = BancoAuxiliar.TratarDados(Jogo.VerificarVez(infosDaPartida.Id));
            lblIdPartida.Text = infosDaPartida.Id.ToString();
            infosDaPartida.Status = (dadosPartida == null ? infosDaPartida.Status : dadosPartida[0].Split(',')[1]);
            lblStatusPartida.Text = infosDaPartida.Status == "A" ? "Aberta" : "Em andamento";
            lblNomeJogador.Text = jogador.Nome;
            lblConstSenhaJogadorLogado.Text = jogador.Senha;
            lblNomeDoGrupo.Text = infosDaPartida.NomeGrupo;
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            //Fim
            //Informações dos jogadores presentes no lobby
            lstJogadoresLobby.Items.Clear();
            string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(infosDaPartida.Id));
            if (jogadores == null)//Compara com null devido ao retorno do tratar dados
            {
                lstJogadoresLobby.Items.Add("Erro ao atualizar lista");
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
                listaJogadores = Jogo.ListarJogadores(infosDaPartida.Id);
                infosDaPartida.QuantidadeJogadoresPartida(jogador);
                Sala sala = new Sala(infosDaPartida, jogador);
                infosDaPartida.Status = "Jogando";
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