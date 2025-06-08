using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KingMeServer;
using sistema_autonomo.Classes;

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
            tmrAtualizarLobby.Enabled = true;
        }

        private void tmrAtualizarLobby_Tick(object sender, EventArgs e)
        {
            //Dados do lobby
            string[] dadosDoLobby = BancoAuxiliar.TratarDados(Jogo.VerificarVez(partida.Id));
            lblIdPartida.Text = partida.Id.ToString();
            partida.Status = (dadosDoLobby == null ? partida.Status : dadosDoLobby[0].Split(',')[1]);
            lblStatusPartida.Text = partida.Status == "Aberta" ? "Aberta" : "Jogando";
            lblVersaoDoJogo.Text = Jogo.versao.ToString();
            //Informações dos jogadores presentes no lobby
            string[] jogadores = BancoAuxiliar.TratarDados(Jogo.ListarJogadores(partida.Id));
            List<Jogador> listaJogadores = new List<Jogador>();
            listaJogadores.Clear();
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                string[] jogadoresSplit = jogadores[i].Split(',');
                JogadorPartida novoJogador = new JogadorPartida(Convert.ToInt32(jogadoresSplit[0]), jogadoresSplit[1], 0, 0);
                listaJogadores.Add(novoJogador);
            }

            dgvLobby.Rows.Clear();
            foreach (JogadorPartida jogador in listaJogadores)
            {
                dgvLobby.Rows.Add(
                    jogador.Id,
                    jogador.Nome
                );

            }
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string verificacaoInicio = Jogo.Iniciar(jogadorLocal.Id, jogadorLocal.Senha);
            if (verificacaoInicio.Substring(0, 1) != "E" || verificacaoInicio == "ERRO:Partida não está aberta")
            {
                partida.Rodada = 1;
                partida.Status = "Jogando";
                tmrAtualizarLobby.Stop();
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