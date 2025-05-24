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
        public Login()
        {
            InitializeComponent();
            cboFiltrarPartidas.Items.Add("Todos");
            cboFiltrarPartidas.Items.Add("Abertas");
            cboFiltrarPartidas.Items.Add("Jogando");
            cboFiltrarPartidas.Items.Add("Encerradas");
            cboFiltrarPartidas.SelectedIndex = 0; //Define o filtro para "Todos"
            lblVersaoJogo.Text = Jogo.versao;
        }
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            //Lógica para add partidas na lista e filtro de partidas
            string[] partidas = BancoAuxiliar.TratarDados(Jogo.ListarPartidas("T"));
            lstPartidas.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                if (cboFiltrarPartidas.Text.Substring(0, 1) == "T")
                {
                    lstPartidas.Items.Add(partidas[i]);
                }
                //Pega a última letra das info. da partida do servidor para determinar o filtro.
                else if (cboFiltrarPartidas.Text.Substring(0, 1) == partidas[i].Substring(partidas[i].Length - 1, 1))
                {
                    lstPartidas.Items.Add(partidas[i]);
                }
            }
        }
        public void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Informações da Partida selecionada
            string[] partidaSelecionada = lstPartidas.SelectedItem.ToString().Split(',');
            partida.Id = (Convert.ToInt32(partidaSelecionada[0]));
            partida.Nome = (partidaSelecionada[1]);
            partida.Data = (partidaSelecionada[2]);
            partida.Status = (partidaSelecionada[3]);
            //Informações dos jogadores presentes na partida selecionada
            string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(partida.Id));
            lstJogadores.Items.Clear();
            if (jogadores == null)//Compara com null devido ao retorno do tratar dados
            {
                lstJogadores.Items.Add("Nenhum jogador na partida!");
                return;
            }
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
            //Fim
        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            partida.Nome = txtInputNomePartida.Text.Trim();
            partida.Senha = txtInputSenhaPartida.Text.Trim();
            if (partida.Nome == "" || partida.Senha == "")
            {
                MessageBox.Show("ERRO: Nome ou senha invalidos");
            }
            else
            {
                string idPartidaCriada = Jogo.CriarPartida(partida.Nome, partida.Senha, partida.NomeGrupo);
                MessageBox.Show($"Partida criada com sucesso!\nO ID da sua partida é {idPartidaCriada}");
            }
        }
        private void btnEntrarPartida_Click_1(object sender, EventArgs e)
        {
            string controller_nome_jogador = txtNomeDoJogador.Text.Trim();
            string controller_senha_partida = txtSenhaEntrarPartida.Text.Trim();
            // Instância única de jogador local
            JogadorLocal jogadorLocal;
            string iniciarPartida = Jogo.Entrar(partida.Id, controller_nome_jogador, controller_senha_partida);
            string[] dadosTratados = iniciarPartida.Split(',');
            if (iniciarPartida.Substring(0, 1) != "E")
            {
                int controller_id = Convert.ToInt32(dadosTratados[0]);
                string controller_senha_jogador = dadosTratados[1];
                jogadorLocal = new JogadorLocal(controller_id, controller_nome_jogador, controller_senha_jogador, 0, 3);
                this.Hide();
                Lobby telaLobby = new Lobby(partida, jogadorLocal);
                telaLobby.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(iniciarPartida);
            }
        }
    }
}