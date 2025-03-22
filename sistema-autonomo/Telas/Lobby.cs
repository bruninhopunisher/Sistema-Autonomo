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
        public int idJogadorLogado { get; set; }
        Partida partidaSelecionada;
        Jogador jogadorSelecionado;

        public Lobby(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();

            partidaSelecionada = partidaRecebida;
            jogadorSelecionado = jogadorRecebido;
            lblConstIdJogadorLogado.Text = jogadorSelecionado.GetId().ToString();
            lblConstSenhaJogadorLogado.Text = jogadorSelecionado.GetSenha().ToString();

            //DataGrid com nome dos personagens (Usar para Jogadores)
            //dgvPersonagens.DataSource = Personagem.ListarPersonagem(0);
            //dgvPersonagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvPersonagens.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dgvPersonagens.AllowUserToResizeRows = false;
            //dgvPersonagens.AllowUserToResizeColumns = false;
            //dgvPersonagens.RowHeadersVisible = false;
            //dgvPersonagens.Columns[0].Visible = false;
            //dgvPersonagens.Columns[1].HeaderText = "Nome do Personagem";
            //dgvPersonagens.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvPersonagens.Columns[2].HeaderText = "Posição";
            //dgvPersonagens.Columns[3].HeaderText = "Status";
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

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        //Botão deletado (Pegar apenas referencia)
        //private void btnAltPosicionarPersonagem_Click(object sender, EventArgs e)
        //{
        //    if (dgvPersonagens.SelectedRows.Count > 0)
        //    {

        //        Personagem personagemSelecionado = (Personagem)dgvPersonagens.SelectedRows[0].DataBoundItem;

        //        if (personagemSelecionado != null && !string.IsNullOrEmpty(personagemSelecionado.nome) && lstSetores.SelectedItem != null)
        //        {
        //            string nomePersonagemSelecionado = personagemSelecionado.nome;
        //            string setorPersonagemSelecionado = lstSetores.SelectedItem.ToString();
        //            string[] setores = setorPersonagemSelecionado.Split(',');

        //            string estadoTabuleiro = Jogo.ColocarPersonagem(
        //                jogadorSelecionado.GetId(),
        //                jogadorSelecionado.GetSenha(),
        //                Convert.ToInt32(setores[0]),
        //                nomePersonagemSelecionado.Substring(0, 1)
        //            );

        //            MessageBox.Show(estadoTabuleiro.ToString());
        //        }
        //        else
        //        {
        //            MessageBox.Show("Por favor, selecione um personagem e um setor válido.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor, selecione uma linha válida no DataGridView.");
        //    }

        //}

        //Botao deletado (Botao ja feito em Sala)
        //private void btnAltAtualizarLista_Click(object sender, EventArgs e)
        //{
        //    int indice = 0;
        //    int idRetornado;
        //    string nomeRetornado;
        //    int indiceRecebido = 0;
        //    string verificarVez = Jogo.VerificarVez(partidaSelecionada.getID());

        //    string dadosJogadores = Jogo.ListarJogadores(partidaSelecionada.getID());
        //    dadosJogadores = dadosJogadores.Replace("\r", "");
        //    string[] dadosJogadorestratados = dadosJogadores.Split('\n');

        //    StructJogador[] structJogadores = new StructJogador[6];

        //    foreach (string dadosJogadorestratado in dadosJogadorestratados)
        //    {
        //        if (string.IsNullOrWhiteSpace(dadosJogadorestratado)) continue;

        //        string[] valores = dadosJogadorestratado.Split(',');
        //        if (valores.Length < 3) continue;

        //        structJogadores[indice].id = valores[0];
        //        structJogadores[indice].nome = valores[1];
        //        structJogadores[indice].pontos = valores[2];
        //        indice++;
        //    }

        //    if (verificarVez.Substring(0, 4) != "ERRO")
        //    {
        //        verificarVez = verificarVez.Replace("\r", "");
        //        string[] tabuleiro = verificarVez.Split('\n');
        //        lstTabuleiroDoJogo.Items.Clear();
        //        for (int i = 0; i < tabuleiro.Length - 1; i++)
        //        {
        //            lstTabuleiroDoJogo.Items.Add(tabuleiro[i]);
        //        }
        //        string[] dadosPartida = tabuleiro[0].Split(',');
        //        int jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez

        //        for (int i = 0; i < indice; i++)
        //        {
        //            if (Convert.ToInt32(structJogadores[i].id) == jogadorVez)
        //            {
        //                idRetornado = Convert.ToInt32(structJogadores[i].id);
        //                nomeRetornado = structJogadores[i].nome;
        //                indiceRecebido = i;
        //            }
        //        }

        //        if (idJogadorLogado == jogadorVez)
        //        {
        //            lblConstMostrarVez.Text = $"É a sua vez ID {jogadorSelecionado.GetId()}: {jogadorSelecionado.GetNome()}";
        //        }
        //        else
        //        {
        //            lblConstMostrarVez.Text = $"É a vez do ID {structJogadores[indiceRecebido].id}: {structJogadores[indiceRecebido].nome}";
        //        }

        //        //dgvPersonagens.DataSource = Personagem.ListarPersonagem(5);
        //    }
        //    else
        //    {
        //        MessageBox.Show(verificarVez);
        //    }
        //}
    }
}