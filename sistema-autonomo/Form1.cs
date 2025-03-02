using KingMeServer;
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
        public Form1()
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
        private void lstListaDePartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partidaSelecionadaRecebida = lstListaDePartidas.SelectedItem.ToString();
            string[] partidaSelecionada = partidaSelecionadaRecebida.Split(',');

            int idPartidaSelecionada = Convert.ToInt32(partidaSelecionada[0]);
            string nomePartidaSelecionada = partidaSelecionada[1];
            string dataPartidaSelecionada = partidaSelecionada[2];
            string statusPartidaSelecionada = partidaSelecionada[3];

            lblIdPartidaSelecionada.Text = idPartidaSelecionada.ToString();
            lblNomePartidaSelecionada.Text = nomePartidaSelecionada;
            lblDataPartidaSelecionada.Text = dataPartidaSelecionada;
            
            switch (statusPartidaSelecionada)
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

            string jogadoresRecebidos = Jogo.ListarJogadores(idPartidaSelecionada);
            
            //Informa quando não tem nenhum jogador
            if(jogadoresRecebidos == "")
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
            string nomeGrupo = txtInputNomeGrupo.Text.Trim();

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
            else if (nomeGrupo == "")
            {
                MessageBox.Show("ERRO: informe o nome do grupo");
                return;
            }
            else
            {   
                string idPartidaCriada = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);
                MessageBox.Show($"Partida criada com sucesso!\nO ID da sua partida é {idPartidaCriada}");
            }
        }
    }
}
