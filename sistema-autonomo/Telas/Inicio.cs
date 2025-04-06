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


            string listaJogadores = Jogo.ListarJogadores(573);

            //listaJogadores = listaJogadores.Replace("\r", "");

            //// Separa cada jogador por linha
            //string[] linhasDeJogadores = listaJogadores.Split('\n');

            //foreach (string linha in linhasDeJogadores)
            //{
            //    if (!string.IsNullOrWhiteSpace(linha))
            //    {
            //        string[] partes = linha.Split(',');

            //        if (partes.Length >= 2)
            //        {
            //            string id = partes[0];
            //            string nome = partes[1];

            //            Console.WriteLine($"ID: {id}, Nome: {nome}");
            //        }
            //    }
            //}

            //string listaJogadores = Jogo.ListarJogadores(554);

            //listaJogadores = listaJogadores.Replace("\r", "");
            //listaJogadores = listaJogadores.Replace("\n", "");
            //string []listaDeJogadoresTratados = listaJogadores.Split(',');

            //for (int i = 1; i < listaDeJogadoresTratados.Length - 1; i += 2)
            //{
            //    Console.WriteLine(listaDeJogadoresTratados[i].ToString());
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
