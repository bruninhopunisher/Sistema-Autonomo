using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo
{
    public class Personagem
    {

        public int id { get; set; }
        public string nome { get; set; }

        public int setor { get; set; }

        public bool foiDeBase { get; set; }


        //public int id;
        //public string nome;
        //public int posicao;
        //public bool foiDeBase;

        //public int GetId()
        //{
        //    return this.id;
        //}
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}
        //public string GetNome()
        //{
        //    return this.nome;
        //}
        //public void SetNome(string nome)
        //{
        //    this.nome = nome;
        //}
        //public int GetPosicao()
        //{
        //    return this.posicao;
        //}
        //public void SetPosicao(int posicao)
        //{
        //    this.posicao = posicao;
        //}
        //public bool GetFoiDeBase()
        //{
        //    return this.foiDeBase;
        //}
        //public void SetFoiDeBase(bool foiDeBase)
        //{
        //    this.foiDeBase = foiDeBase;
        //}

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
                personagens_instancia.Add(novoPersonagem);
            }
            return personagens_instancia;
        }


    }
}
