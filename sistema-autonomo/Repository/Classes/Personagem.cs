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
        private List<Point> point;
        public static List<Personagem> personagenInstanciado = new List<Personagem>();
       
        public Personagem()
        {
            this.point = new List<Point>();
            point.Add(new Point(50, 500));
            point.Add(new Point(200, 500));
            point.Add(new Point(350, 500));
            point.Add(new Point(500, 500));
            point.Add(new Point(50, 650));
            point.Add(new Point(200, 650));
            point.Add(new Point(350, 650));
            point.Add(new Point(500, 650));
            point.Add(new Point(650, 650));
            point.Add(new Point(50, 800));
            point.Add(new Point(200, 800));
            point.Add(new Point(350, 800));
            point.Add(new Point(500, 800));
        }

        public List<Point> PointInicial
        {
            get { return point; }
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
