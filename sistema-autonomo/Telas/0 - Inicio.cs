using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using sistema_autonomo.Classes;

namespace sistema_autonomo
{
    public partial class Inicio : Form
    {
        public Partida partida = new Partida();
        public Inicio()
        {
            InitializeComponent();
            lblVersaoJogo.Text = Jogo.versao.ToString();
            lblNomeGrupo.Text = partida.NomeGrupo;

            // Vou implementar depois na Sala
            string retorno = Jogo.ListarJogadores(5);

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            List<JogadorPartida> listaJogadores = new List<JogadorPartida>(); 
            
            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                string jogador = jogadores[i];
                string[] dados = jogador.Split(',');

                JogadorPartida j = new JogadorPartida(Convert.ToInt32(dados[0]), dados[1], Convert.ToInt32(dados[2]), 0);

                listaJogadores.Add(j);
            }
            dgvSala.DataSource = listaJogadores;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.ShowDialog();
            this.Close();
        }
    }
}
