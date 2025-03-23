using KingMeServer;
using sistema_autonomo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo
{

    public partial class Login : Form
    {
        public Partida partida = new Partida();
        public Jogador JogadorLogado = new Jogador();
        public Login()
        {

            InitializeComponent();


            cboFiltrarPartidas.Items.Add("Todos");
            cboFiltrarPartidas.Items.Add("Abertas");
            cboFiltrarPartidas.Items.Add("Jogando");
            cboFiltrarPartidas.Items.Add("Encerradas");
            cboFiltrarPartidas.SelectedIndex = 0;
            lblVersaoJogo.Text = Jogo.versao;

        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string listaDePartidas = Jogo.ListarPartidas("T");
            listaDePartidas = listaDePartidas.Replace("\r", "");
            string[] partidas = listaDePartidas.Split('\n');

            //Adiciona as partidas na lista
            lstListaDePartidas.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                if (cboFiltrarPartidas.Text.Substring(0, 1) == "T")
                {
                    lstListaDePartidas.Items.Add(partidas[i]);
                }
                if (cboFiltrarPartidas.Text.Substring(0, 1) == partidas[i].Substring(partidas[i].Length - 1, 1))//Dado indice (i), recorta o ultimo caractere.
                {
                    lstListaDePartidas.Items.Add(partidas[i]);
                }

            }
        }


        public void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e)
        {


            string partidaSelecionadaRecebida = lstListaDePartidas.SelectedItem.ToString();
            string[] partidaSelecionada = partidaSelecionadaRecebida.Split(',');

            partida.setID(Convert.ToInt32(partidaSelecionada[0]));
            partida.setNome(partidaSelecionada[1]);
            partida.setData(partidaSelecionada[2]);
            partida.setStatus(partidaSelecionada[3]);

            lblIdPartidaSelecionada.Text = partida.getID().ToString();
            lblNomePartidaSelecionada.Text = partida.getNome();
            lblDataPartidaSelecionada.Text = partida.getData();

            switch (partida.getStatus())
            {
                case "A":
                    lblStatusPartidaSelecionada.Text = "Aberta";
                    break;
                case "J":
                    lblStatusPartidaSelecionada.Text = "Jogando";
                    break;
                case "E":
                    lblStatusPartidaSelecionada.Text = "Encerrada";
                    break;
            }

            string jogadoresRecebidos = Jogo.ListarJogadores(partida.getID());

            //Informa quando não tem nenhum jogador
            if (jogadoresRecebidos == "")
            {
                lstJogadores.Items.Clear();
                lstJogadores.Items.Add("Nenhum jogador na partida!");
                return;
            }

            jogadoresRecebidos = jogadoresRecebidos.Replace("\r", "");
            string[] jogadores = jogadoresRecebidos.Split('\n');

            //Adiciona todos os jogadores na lista
            lstJogadores.Items.Clear();
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtInputNomePartida.Text.Trim();
            string senhaPartida = txtInputSenhaPartida.Text.Trim();

            if (nomePartida == "")
            {
                MessageBox.Show("ERRO: informe o nome da partida");
                return;
            }
            else if (senhaPartida == "")
            {
                MessageBox.Show("ERRO: informe a senha da partida");
                return;
            }

            else
            {
                string idPartidaCriada = Jogo.CriarPartida(nomePartida, senhaPartida, "Estudantes de Bolonha");
                MessageBox.Show($"Partida criada com sucesso!\nO ID da sua partida é {idPartidaCriada}");
            }
        }



        private void btnEntrarPartida_Click_1(object sender, EventArgs e)
        {


            string[] dadosJogador = new string[2];
            string senhaDigitada = txtSenhaEntrarPartida.Text.Trim();
            string nomeDoJogador = txtNomeDoJogador.Text.Trim();
            string dadosRecebidos = Jogo.Entrar(partida.getID(), nomeDoJogador, senhaDigitada);

            dadosJogador = dadosRecebidos.Split(',');

            if (dadosRecebidos.Substring(0, 4) != "ERRO")
            {
                JogadorLogado.SetId(Convert.ToInt32(dadosJogador[0]));
                JogadorLogado.SetSenha(dadosJogador[1]);
                JogadorLogado.SetNome(nomeDoJogador);
                Lobby LobbyPartida1 = new Lobby(partida, JogadorLogado);
                LobbyPartida1.idJogadorLogado = JogadorLogado.GetId();
                LobbyPartida1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(dadosJogador[0]);
            }
        }
    }
}