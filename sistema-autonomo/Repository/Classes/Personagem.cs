using KingMeServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo
{
    public class Personagem
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int setor { get; set; }
        public bool foiDeBase { get; set; }
        public PictureBox cardPersonagem { get; set; }
        public bool personagemPosicionado { get; set; }
        private List<Point> pointPersonagens;
        public static List<Personagem> personagenInstanciado = new List<Personagem>();
       
        public Personagem()
        {
            this.pointPersonagens = new List<Point>();
            pointPersonagens.Add(new Point(355, 431));
            pointPersonagens.Add(new Point(419, 431));
            pointPersonagens.Add(new Point(483, 431));
            pointPersonagens.Add(new Point(547, 431));
            pointPersonagens.Add(new Point(611, 431));
            pointPersonagens.Add(new Point(675, 431));
            pointPersonagens.Add(new Point(739, 431));
            pointPersonagens.Add(new Point(355, 513));
            pointPersonagens.Add(new Point(419, 513));
            pointPersonagens.Add(new Point(483, 513));
            pointPersonagens.Add(new Point(547, 513));
            pointPersonagens.Add(new Point(611, 513));
            pointPersonagens.Add(new Point(675, 513));
        }

        public List<Point> PointPersonagens
        {
            get { return pointPersonagens; }
        }
        public static List<Personagem> ListarPersonagem(int setor)
        {
            string listaPersonagens = Jogo.ListarPersonagens();
            listaPersonagens = listaPersonagens.Replace("\r", "");
            string[] personagens = listaPersonagens.Split('\n');
            List<Personagem> personagens_instancia = new List<Personagem>();

            for (int i = 0; i < personagens.Length - 1; i++)
            {
                Personagem novoPersonagem = new Personagem();
                novoPersonagem.id = i;
                novoPersonagem.nome = personagens[i];
                novoPersonagem.setor = setor;
                novoPersonagem.foiDeBase = false;
                novoPersonagem.personagemPosicionado = false;
                personagens_instancia.Add(novoPersonagem);
                personagenInstanciado.Add(novoPersonagem);
                
            }
            return personagens_instancia;
        }
    }
}
