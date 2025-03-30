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
        public Inicio()
        {
            InitializeComponent();
            lblVersaoJogo.Text = Jogo.versao.ToString();
            lblNomeGrupo.Text = Lobby.GetNomeGrupo().ToString();
            MessageBox.Show(Jogo.VerificarVez(148));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
