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
        private DataGridViewRow linhaSelecDgvPartidas;
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
            List<Partida> listaPartidas = new List<Partida>();
            string[] partidas = BancoAuxiliar.TratarDados(Jogo.ListarPartidas("T"));
            if (partidas == null)
            {
                return;
            }
            listaPartidas.Clear();
            if (cboFiltrarPartidas.Text.Substring(0, 1) == "T")
            {
                for (int i = 0; i < partidas.Length - 1; i++)
                {
                    string[] dadosPartida = partidas[i].Split(',');
                    Partida novaPartida = new Partida();
                    novaPartida.Id = Convert.ToInt32(dadosPartida[0]);
                    novaPartida.Nome = dadosPartida[1];
                    novaPartida.Data = dadosPartida[2];
                    novaPartida.Status = dadosPartida[3];
                    listaPartidas.Add(novaPartida);
                }
            }
            else 
            {
                for (int i = 0; i < partidas.Length - 1; i++)
                {
                    if(cboFiltrarPartidas.Text.Substring(0, 1) == partidas[i].Substring(partidas[i].Length - 1, 1))
                    {
                        string[] dadosPartida = partidas[i].Split(',');
                        Partida novaPartida = new Partida();
                        novaPartida.Id = Convert.ToInt32(dadosPartida[0]);
                        novaPartida.Nome = dadosPartida[1];
                        novaPartida.Status = dadosPartida[3];
                        listaPartidas.Add(novaPartida);
                    }
                }
            }
            dgvPartidas.Rows.Clear();
            foreach (Partida partida in listaPartidas)
            {
                dgvPartidas.Rows.Add(
                    partida.Id,
                    partida.Nome,
                    partida.Status
                );
            }


        }
        private void dgvPartidas_SelectionChanged(object sender, EventArgs e)
        {
            //Informações da Partida selecionada
             linhaSelecDgvPartidas = dgvPartidas.CurrentRow;
            if (linhaSelecDgvPartidas != null)
            {
                partida.Id = Convert.ToInt32(linhaSelecDgvPartidas.Cells["ID"].Value);
                partida.Nome = linhaSelecDgvPartidas.Cells["NOME"].Value.ToString();
                partida.Status = linhaSelecDgvPartidas.Cells["STATUS"].Value.ToString();
                //Informações dos jogadores presentes na partida selecionada
                string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(partida.Id));
                lstJogadores.Items.Clear();
                if (jogadores == null)//Compara com null devido ao retorno do tratar dados
                {
                    lstJogadores.Items.Add("Nenhum jogador na partida!");
                    return;
                }
                for (int i = 0; i < jogadores.Length - 1; i++)
                {
                    string[] dadosJogadorSeparado = jogadores[i].Split(',');
                    lstJogadores.Items.Add(dadosJogadorSeparado[1]);
                }
                //Fim
            }
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