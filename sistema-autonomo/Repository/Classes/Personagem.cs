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
            point.Add(new Point(26, 399));
            point.Add(new Point(99, 399));
            point.Add(new Point(99, 572));
            point.Add(new Point(172, 486));
            point.Add(new Point(172, 399));
            point.Add(new Point(172, 572));
            point.Add(new Point(327, 485));
            point.Add(new Point(245, 573));
            point.Add(new Point(245, 486));
            point.Add(new Point(26, 485));
            point.Add(new Point(245, 399));
            point.Add(new Point(26, 572));
            point.Add(new Point(99, 486));
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

        public void AlterarSetorPersonagem(string nome, int setor)
        {
            List<Personagem> personagens = ListarPersonagem(this.setor);
            this.nome = nome;
            this.setor = setor;

            for (int i = 0; i < personagens.Count; i++)
            {
                if (nome == personagens[i].nome)
                {
                    personagens[i].setor = setor;
                }
            }
        }
    }
}
