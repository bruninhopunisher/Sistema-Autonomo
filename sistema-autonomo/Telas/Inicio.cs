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
            //string tabuleiroRecebido = Jogo.VerificarVez(1244);
            //tabuleiroRecebido.Replace("\r", "");
            //string[] tabuleiroSala = tabuleiroRecebido.Split('\n');
            //for(int i = 1; tabuleiroSala.Length - 1 > 0; i++)
            //{
            //    string[] personagemNoSetor = tabuleiroSala[i].Split(',');
            //    MessageBox.Show(personagemNoSetor[0]);
            //}
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Hide();
        }
    }
}
