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

    public partial class Form1 : Form
    {
        public Partida partidaSelecionada = new Partida();
        public Jogador JogadorLogado = new Jogador();
        public Lobby lobby = new Lobby();

        public Form1()
        {
            InitializeComponent();
            cboFiltrarPartidas.Items.Add("Todos");
            cboFiltrarPartidas.Items.Add("Abertas");
            cboFiltrarPartidas.Items.Add("Jogando");
            cboFiltrarPartidas.Items.Add("Encerradas");
            cboFiltrarPartidas.SelectedIndex = 0;
            lblVersaoJogo.Text = Jogo.versao;

            //LobbyPartida LobbyPartida1 = new LobbyPartida(partida, JogadorLogado);

            //LobbyPartida1.ShowDialog();
            //this.Hide();t


        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            //string listaDePartidas = Jogo.ListarPartidas("T");
            //listaDePartidas = listaDePartidas.Replace("\r", "");
            //string[] partidas = listaDePartidas.Split('\n');

            string[] partidas = Lobby.ListarPartidas();

            //Adiciona as partidas na lista
            lstListaDePartidas.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                if(cboFiltrarPartidas.Text.Substring(0, 1) == "T")
                {
                    lstListaDePartidas.Items.Add(partidas[i]);
                }
                if(cboFiltrarPartidas.Text.Substring(0,1) == partidas[i].Substring(partidas[i].Length - 1, 1))//Dado indice (i), recorta o ultimo caractere.
                {
                    lstListaDePartidas.Items.Add(partidas[i]);
                }

            }
         }

        public void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e)
        {   
            string partidaSelecionadaRecebida = lstListaDePartidas.SelectedItem.ToString();
            string[] partidaSelecionadaSplit = partidaSelecionadaRecebida.Split(',');

            partidaSelecionada.setID(Convert.ToInt32(partidaSelecionadaSplit[0]));
            partidaSelecionada.setNome (partidaSelecionadaSplit[1]);
            partidaSelecionada.setData(partidaSelecionadaSplit[2]);
            partidaSelecionada.setStatus(partidaSelecionadaSplit[3]);

            lblIdPartidaSelecionada.Text = partidaSelecionada.getID().ToString();
            lblNomePartidaSelecionada.Text = partidaSelecionada.getNome();
            lblDataPartidaSelecionada.Text = partidaSelecionada.getData();
            
            switch (partidaSelecionada.getStatus())
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

            //string jogadoresRecebidos = Jogo.ListarJogadores(partidaSelecionada.getID());
            ////Informa quando não tem nenhum jogador
            //if(jogadoresRecebidos == "")
            //{
            //    lstJogadores.Items.Clear();
            //    lstJogadores.Items.Add("Nenhum jogador na partida!");
            //    return;
            //}
            //jogadoresRecebidos = jogadoresRecebidos.Replace("\r", "");
            //string[] jogadores = jogadoresRecebidos.Split('\n');

            string[] listaJogadores = Lobby.ListarJogadores(partidaSelecionada);


            //Adiciona todos os jogadores na lista
            lstJogadores.Items.Clear();
            if (listaJogadores[0] == "")
            {
                lstJogadores.Items.Add("Nenhum jogador na partida!");
            }
            else
            {
                for (int i = 0; i < listaJogadores.Length; i++)
                {
                    lstJogadores.Items.Add(listaJogadores[i]);
                }
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nomePartida = txtInputNomePartida.Text.Trim();
            string senhaPartida = txtInputSenhaPartida.Text.Trim();

            //if (nomePartida == "")
            //{
            //    MessageBox.Show("ERRO: informe o nome da partida");
            //    return;
            //}
            //else if (senhaPartida == "")
            //{
            //    MessageBox.Show("ERRO: informe a senha da partida");
            //    return;
            //} 

            //else
            //{   
            //    string idPartidaCriada = Jogo.CriarPartida(nomePartida, senhaPartida, "Estudantes de Bolonha");
            //    MessageBox.Show($"Partida criada com sucesso!\nO ID da sua partida é {idPartidaCriada}");
            //}

            MessageBox.Show(Lobby.CriarPartida(nomePartida, senhaPartida, lobby.nomeGrupo));
        }

        private void btnEntrarPartida_Click_1(object sender, EventArgs e)
        {
            //string[] dadosJogador = new string[2];
            string senhaJogadorRecebida = txtSenhaEntrarPartida.Text.Trim();
            string nomeJogadorRecebido = txtNomeDoJogador.Text.Trim();
            //string dadosRecebidos = Jogo.Entrar(partidaSelecionada.getID(), nomeDoJogador, senhaDigitada);
            //dadosJogador = dadosRecebidos.Split(',');

            string[] dadosJogadorRecebido =  Lobby.EntrarPartida(partidaSelecionada, nomeJogadorRecebido, senhaJogadorRecebida);

            if (dadosJogadorRecebido[0] == "ERRO")
            {
                MessageBox.Show($"{dadosJogadorRecebido[0]}: {dadosJogadorRecebido[1]}");
            }
            else
            {
                JogadorLogado.SetId(Convert.ToInt32(dadosJogadorRecebido[0]));
                JogadorLogado.SetSenha(dadosJogadorRecebido[1]);
                JogadorLogado.SetNome(nomeJogadorRecebido);
                LobbyPartida LobbyPartida1 = new LobbyPartida(partidaSelecionada, JogadorLogado);
                LobbyPartida1.idJogadorLogado = JogadorLogado.GetId();
                LobbyPartida1.Show();
                this.Hide();
            }
        }
    }
}
