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
            lblNomeGrupo.Text = Classes.Lobby.GetNomeGrupo().ToString();
            //string[] personagens = BancoAuxiliar.TratarDados(Jogo.ListarPersonagens());
            //for (int i = 0; i < personagens.Length - 1; i++)
            //{
            //    MessageBox.Show(personagens[i]);
            //}
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.ShowDialog();
            this.Close();
        }
    }
}
