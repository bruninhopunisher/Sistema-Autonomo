using System;
using System.Collections;
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
    public partial class Sala : Form
    {
        Partida partidaSelecionada;
        Jogador jogadorSelecionado;
        Personagem personagem;
        List<Personagem> minhaLista = new List<Personagem>();
        List<PictureBox> listaPic = new List<PictureBox>();

        public Sala(Partida partidaRecebida, Jogador jogadorRecebido)
        {
            InitializeComponent();
            partidaSelecionada = partidaRecebida;
            jogadorSelecionado = jogadorRecebido;

            //Exibir cartas jogador
            string cartasSorteadas = Jogo.ListarCartas(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha());
            lstMinhasCartasSala.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                switch (cartasSorteadas.Substring(i, 1))
                {
                    case "A":
                        lstMinhasCartasSala.Items.Add("Adilson Konrad");
                        break;
                    case "B":
                        lstMinhasCartasSala.Items.Add("Beatriz Paiva");
                        break;
                    case "C":
                        lstMinhasCartasSala.Items.Add("Claro");
                        break;
                    case "D":
                        lstMinhasCartasSala.Items.Add("Douglas Baquiao");
                        break;
                    case "E":
                        lstMinhasCartasSala.Items.Add("Eduardo Takeo");
                        break;
                    case "G":
                        lstMinhasCartasSala.Items.Add("Guilherme Rey");
                        break;
                    case "H":
                        lstMinhasCartasSala.Items.Add("Heredia");
                        break;
                    case "K":
                        lstMinhasCartasSala.Items.Add("Karin");
                        break;
                    case "L":
                        lstMinhasCartasSala.Items.Add("Leonardo Takuno");
                        break;
                    case "M":
                        lstMinhasCartasSala.Items.Add("Mario Toledo");
                        break;
                    case "Q":
                        lstMinhasCartasSala.Items.Add("Quintas");
                        break;
                    case "R":
                        lstMinhasCartasSala.Items.Add("Ranulfo");
                        break;
                    case "T":
                        lstMinhasCartasSala.Items.Add("Toshio");
                        break;
                }
            }

            //Exibir setores da partida
            string listaSetores = Jogo.ListarSetores();
            listaSetores = listaSetores.Replace("\r", "");
            string[] setores = listaSetores.Split('\n');
            for (int i = 0; i < setores.Length - 1; i++)
            {
                lstSetoresSala.Items.Add(setores[i]);
            }
        }

        private void btnConstVerificarVez_Click_1(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem();
            int indice = 0;
            int idRetornado;
            string nomeRetornado;
            int indiceRecebido = 0;
            string verificarVez = Jogo.VerificarVez(partidaSelecionada.getID());

            string dadosJogadores = Jogo.ListarJogadores(partidaSelecionada.getID());
            dadosJogadores = dadosJogadores.Replace("\r", "");
            string[] dadosJogadorestratados = dadosJogadores.Split('\n');

            StructJogador[] structJogadores = new StructJogador[6];

            foreach (string dadosJogadorestratado in dadosJogadorestratados)
            {
                if (string.IsNullOrWhiteSpace(dadosJogadorestratado)) continue;

                string[] valores = dadosJogadorestratado.Split(',');
                if (valores.Length < 3) continue;

                structJogadores[indice].id = valores[0];
                structJogadores[indice].nome = valores[1];
                structJogadores[indice].pontos = valores[2];
                indice++;
            }

            if (verificarVez.Substring(0, 4) != "ERRO")
            {
                verificarVez = verificarVez.Replace("\r", "");
                string[] tabuleiro = verificarVez.Split('\n');
                lstAltTabuleiroSala.Items.Clear();
                for (int i = 0; i < tabuleiro.Length - 1; i++)
                {
                    lstAltTabuleiroSala.Items.Add(tabuleiro[i]);
                }
                string[] dadosPartida = tabuleiro[0].Split(',');
                int jogadorVez = Convert.ToInt32(dadosPartida[0]); //ID do jogador da vez

                for (int i = 0; i < indice; i++)
                {
                    if (Convert.ToInt32(structJogadores[i].id) == jogadorVez)
                    {
                        idRetornado = Convert.ToInt32(structJogadores[i].id);
                        nomeRetornado = structJogadores[i].nome;
                        indiceRecebido = i;
                    }
                }

                if (jogadorSelecionado.GetId() == jogadorVez)
                {
                    lblAltStatusVezSala.Text = $"É a sua vez ID {jogadorSelecionado.GetId()}: {jogadorSelecionado.GetNome()}";
                }
                else
                {
                    lblAltStatusVezSala.Text = $"É a vez do ID {structJogadores[indiceRecebido].id}: {structJogadores[indiceRecebido].nome}";
                }

                //dgvPersonagens.DataSource = Personagem.ListarPersonagem(5);
            }
            else
            {
                MessageBox.Show(verificarVez);
                //Jogo.ColocarPersonagem(jogadorSelecionado.GetId);
            }

            minhaLista = Personagem.ListarPersonagem(0);
            lstCartas.Items.Clear();

            // Colocando as cartas na lstbox
            for (int i = 0; i < minhaLista.Count; i++)
            {
                lstCartas.Items.Add(minhaLista[i].nome);
            }
        }

        private void btnPosicionar_Click(object sender, EventArgs e)
        {
            if (lstCartas.SelectedItem != null)
            {
                string nomecartaSelecionada = lstCartas.SelectedItem.ToString();
                nomecartaSelecionada = lstCartas.SelectedItem.ToString();
                string NomeRecortado = nomecartaSelecionada.Substring(0, 1);
                // MessageBox.Show(nomecartaSelecionada);
                string nomeSetor = lstSetoresSala.SelectedItem.ToString();
                int numeroSetorSelecionado = Convert.ToInt32(nomeSetor.Substring(0, 1));

                string retornoColocar = Jogo.ColocarPersonagem(jogadorSelecionado.GetId(), jogadorSelecionado.GetSenha(), numeroSetorSelecionado, NomeRecortado);
                Console.WriteLine(retornoColocar);
                retornoColocar.Replace("\r", "");
                string[] dadosRetornados = retornoColocar.Split('\n');

                // Metodo classe personagem para alterar a posicao do personagem um pouco a baixo
                for (int i = 0; i < dadosRetornados.Length - 1; i++)
                {
                    // Retorna a letra inicial na variavel person
                    string person = dadosRetornados[i].Substring(0, 3);
                    int setor = Convert.ToInt32(dadosRetornados[i].Substring(0, 1));

                    personagem.AlterarSetorPersonagem(person, setor);
                }
                
                /*
                for (int i = 0; i < minhaLista.Count(); i++)
                {
                    Personagem personagemEmandamento = new Personagem();
                    personagemEmandamento = minhaLista[i];
                    string nomeDavez = personagemEmandamento.nome;
                    nomeDavez = nomeDavez.Substring(0, 1);
                    if(nomeDavez == retornoColocar)
                    {
                        //picAdilson.Name
                    }
                }
                */
                //Botão deletado (Pegar apenas referencia)
                /*
                if (dgvPersonagens.SelectedRows.Count > 0)
                {

                    Personagem personagemSelecionado = (Personagem)dgvPersonagens.SelectedRows[0].DataBoundItem;

                    if (personagemSelecionado != null && !string.IsNullOrEmpty(personagemSelecionado.nome) && lstSetores.SelectedItem != null)
                    {
                        string nomePersonagemSelecionado = personagemSelecionado.nome;
                        string setorPersonagemSelecionado = lstSetores.SelectedItem.ToString();
                        string[] setores = setorPersonagemSelecionado.Split(',');

                        string estadoTabuleiro = Jogo.ColocarPersonagem(
                            jogadorSelecionado.GetId(),
                            jogadorSelecionado.GetSenha(),
                            Convert.ToInt32(setores[0]),
                            nomePersonagemSelecionado.Substring(0, 1)
                        );

                        MessageBox.Show(estadoTabuleiro.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um personagem e um setor válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma linha válida no DataGridView.");
                }
            }
        

                void picAdilson_Click(object sender, EventArgs e)
            {

            }
            */
            }
            MessageBox.Show("Selecione um personagem para posicionar!");
        }
    }
}