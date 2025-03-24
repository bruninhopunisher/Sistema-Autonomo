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
    public partial class LobbyEspera : Form
    {
        public int idJogadorLogado { get; set; }
        Partida partidaSelecionada;
        Jogador jogadorSelecionado;

        public LobbyEspera(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            lblNomeDoGrupo.Text = Lobby.GetNomeGrupo().ToString();
            partidaSelecionada = partidaRecebida;
            jogadorSelecionado = jogadorRecebido;
            lblConstIdJogadorLogado.Text = jogadorSelecionado.GetId().ToString();
            lblConstSenhaJogadorLogado.Text = jogadorSelecionado.GetSenha().ToString();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string verificacaoInicio = Jogo.Iniciar(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha());
            MessageBox.Show(verificacaoInicio);

            Sala sala = new Sala(partidaSelecionada, jogadorSelecionado);
            partidaSelecionada.setStatus("Jogando");
            sala.Show();
            this.Hide();
        }
    }
}