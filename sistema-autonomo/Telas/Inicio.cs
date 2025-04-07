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


            //string listaJogadores = Jogo.ListarJogadores(573);
            //MessageBox.Show(listaJogadores);

            //string[] linhas = listaJogadores.Split('\n');

            //// Cria uma lista para armazenar os IDs
            //List<int> ids = new List<int>();

            //foreach (string linha in linhas)
            //{
            //    if (!string.IsNullOrWhiteSpace(linha)) // Ignora linhas vazias
            //    {
            //        string[] partes = linha.Split(',');
            //        if (partes.Length > 0 && int.TryParse(partes[0], out int id))
            //        {
            //            ids.Add(id);
            //        }
            //    }
            //}

            // Agora você tem todos os IDs em "ids"
            //foreach (int id in ids)
            //{
            //    Console.WriteLine(id); // ou faça o que quiser com os IDs
            //}

            //Console.WriteLine(ids.Count);

            //MessageBox.Show(listaDeJogadoresTratados.ToString());

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.ShowDialog();
            this.Close();
        }
    }
}
