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

            string numeroRodada = Jogo.VerificarVez(2160);
            string[] numeroRodadaTratado = numeroRodada.Split(',');
            Console.WriteLine(numeroRodadaTratado[2]);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.ShowDialog();
            this.Close();
        }
    }
}
