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

namespace sistema_autonomo.Telas
{
    public partial class Final : Form
    {
        public Final(Partida partidaRecebida)
        {
            InitializeComponent();
            partidaRecebida.AtualizarPontuacao();
            //partidaRecebida.ListaJogadores = partidaRecebida.ListaJogadores.OrderByDescending(j => j.QtdPonto).ToList();
            partidaRecebida.ListaJogadores.Sort((a,b) => b.QtdPonto.CompareTo(a.QtdPonto));

            lblAltNomeVencedor1.Text = partidaRecebida.ListaJogadores[0].Nome;
            lblAltPontosVencedor1.Text = partidaRecebida.ListaJogadores[0].QtdPonto.ToString();
            lblAltNomeVencedor1.Text = partidaRecebida.ListaJogadores[1].Nome;
            lblAltPontosVencedor1.Text = partidaRecebida.ListaJogadores[1].QtdPonto.ToString();
            if (partidaRecebida.ListaJogadores.Count > 2)
            {
                lblAltNomeVencedor1.Text = partidaRecebida.ListaJogadores[2].Nome;
                lblAltPontosVencedor1.Text = partidaRecebida.ListaJogadores[2].QtdPonto.ToString();
            }
        }
    }
}
