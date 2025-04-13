using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using KingMeServer;

    public class Tabuleiro
    {
        //Partida partidaSelecionada;
        private Dictionary<int, Point> setoresPosicoes; // Mapeia setores para coordenadas X:Y
        private Dictionary<int, bool> setoresDisponiveis = new Dictionary<int, bool>
            {
                { 60, false },   // 6º
                { 51, false }, { 52, false }, { 53, false }, { 54, false },  // 5º
                { 41, false }, { 42, false }, { 43, false }, { 44, false },  // 4º
                { 31, false }, { 32, false }, { 33, false }, { 34, false },  // 3º
                { 21, false }, { 22, false }, { 23, false }, { 24, false },  // 2º
                { 11, false }, { 12, false }, { 13, false }, { 14, false },  // 1º
                {  1, false }, {  2, false }, {  3, false }, {  4, false }  // 0º
            };
        private Dictionary<int, string> estadoSetorPersonagem = new Dictionary<int, string>
            {
                { 60, null },   // 6º
                { 51, null }, { 52, null }, { 53, null }, { 54, null },  // 5º
                { 41, null }, { 42, null }, { 43, null }, { 44, null },  // 4º
                { 31, null }, { 32, null }, { 33, null }, { 34, null },  // 3º
                { 21, null }, { 22, null }, { 23, null }, { 24, null },  // 2º
                { 11, null }, { 12, null }, { 13, null }, { 14, null },  // 1º
                {  1, null }, {  2, null }, {  3, null }, {  4, null }  // 0º
            };
        public Tabuleiro()
        {
            // Mapeamento das coordenadas dos setores
            setoresPosicoes = new Dictionary<int, Point>
            {
                { 60, new Point(852, 36) },   // 6º
                { 51, new Point(752, 131) }, { 52, new Point(825, 131) }, { 53, new Point(898, 131) }, { 54, new Point(971, 131) },  // 5º
                { 41, new Point(738, 219) }, { 42, new Point(811, 219) }, { 43, new Point(889, 219) }, { 44, new Point(962, 219) },  // 4º
                { 31, new Point(738, 306) }, { 32, new Point(811, 306) }, { 33, new Point(889, 306) }, { 34, new Point(962, 306) },  // 3º
                { 21, new Point(738, 392) }, { 22, new Point(811, 392) }, { 23, new Point(889, 392) }, { 24, new Point(962, 392) },  // 2º
                { 11, new Point(738, 479) }, { 12, new Point(811, 479) }, { 13, new Point(889, 479) }, { 14, new Point(962, 479) },  // 1º
                {  1, new Point(752, 547) }, {  2, new Point(825, 547) }, {  3, new Point(898, 547) }, {  4, new Point(971, 547) }   // 0º
            };
        }

        public void AlterarEstadoSetor(int posicaoSetor)
        {
            setoresDisponiveis[posicaoSetor] = true;
        }

        public Point posicaoSetor(int posicaoSetor)
        {
            return setoresPosicoes[posicaoSetor];
        }

        public bool verificarSetorDisponivel(int setor)
        {
            bool posicaoDisponivel = false;
            switch (setor)
            {
                case 1:
                    setor = 11;
                    for (int i = setor; i <= 14; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if(posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 2:
                    setor = 21;
                    for (int i = setor; i <= 24; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 3:
                    setor = 31;
                    for (int i = setor; i <= 34; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 4:
                    setor = 41;
                    for (int i = setor; i <= 44; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 5:
                    setor = 51;
                    for (int i = setor; i <= 54; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 10:
                    setor = 60;
                    posicaoDisponivel = verificarPosicaoSetorDisponivel(setor);
                    if (posicaoDisponivel == false)
                        return posicaoDisponivel;
                    return posicaoDisponivel;
            }
            return posicaoDisponivel;
        }

        //Verifica se a posicao esta disponivel
        public bool verificarPosicaoSetorDisponivel(int posicaoSetor)
        {
            return setoresDisponiveis[posicaoSetor];
        }

        public List<Personagem> posicionarPersonagem(Dictionary<int, string> estadoTabuleiro, List<Personagem> personagensRecebidos)
        {
            List<Personagem> personagensPosicionados = personagensRecebidos;
            Point novaPosicaoPersonagem;
            //Setor 0
            for (int i = 1; i <= 4; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 1
            for (int i = 11; i <= 14; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 2
            for (int i = 21; i <= 24; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 3
            for (int i = 31; i <= 34; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 4
            for (int i = 41; i <= 44; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 5
            for (int i = 51; i <= 54; i++)
            {
                if (estadoTabuleiro[i] != null)
                {
                    switch (estadoTabuleiro[i].Substring(0, 1))
                    {
                        case "A":
                            if (personagensPosicionados[0].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[0].personagemPosicionado = true;
                            }
                            break;
                        case "B":
                            if (personagensPosicionados[1].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[1].personagemPosicionado = true;
                            }
                            break;
                        case "C":
                            if (personagensPosicionados[2].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[2].personagemPosicionado = true;
                            }
                            break;
                        case "D":
                            if (personagensPosicionados[3].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[3].personagemPosicionado = true;
                            }
                            break;
                        case "E":
                            if (personagensPosicionados[4].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[4].personagemPosicionado = true;
                            }
                            break;
                        case "G":
                            if (personagensPosicionados[5].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[5].personagemPosicionado = true;
                            }
                            break;
                        case "H":
                            if (personagensPosicionados[6].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[6].personagemPosicionado = true;
                            }
                            break;
                        case "K":
                            if (personagensPosicionados[7].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[7].personagemPosicionado = true;
                            }
                            break;
                        case "L":
                            if (personagensPosicionados[8].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[8].personagemPosicionado = true;
                            }
                            break;
                        case "M":
                            if (personagensPosicionados[9].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[9].personagemPosicionado = true;
                            }
                            break;
                        case "Q":
                            if (personagensPosicionados[10].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[10].personagemPosicionado = true;
                            }
                            break;
                        case "R":
                            if (personagensPosicionados[11].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[11].personagemPosicionado = true;
                            }
                            break;
                        case "T":
                            if (personagensPosicionados[12].personagemPosicionado == false)
                            {
                                novaPosicaoPersonagem = posicaoSetor(i);
                                personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                                personagensPosicionados[12].personagemPosicionado = true;
                            }
                            break;
                    }
                }
            }
            //Setor 10
            if (estadoTabuleiro[60] != null)
            {
                switch (estadoTabuleiro[60].Substring(0, 1))
                {
                    case "A":
                        if (personagensPosicionados[0].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[0].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[0].personagemPosicionado = true;
                        }
                        break;
                    case "B":
                        if (personagensPosicionados[1].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[1].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[1].personagemPosicionado = true;
                        }
                        break;
                    case "C":
                        if (personagensPosicionados[2].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[2].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[2].personagemPosicionado = true;
                        }
                        break;
                    case "D":
                        if (personagensPosicionados[3].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[3].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[3].personagemPosicionado = true;
                        }
                        break;
                    case "E":
                        if (personagensPosicionados[4].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[4].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[4].personagemPosicionado = true;
                        }
                        break;
                    case "G":
                        if (personagensPosicionados[5].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[5].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[5].personagemPosicionado = true;
                        }
                        break;
                    case "H":
                        if (personagensPosicionados[6].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[6].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[6].personagemPosicionado = true;
                        }
                        break;
                    case "K":
                        if (personagensPosicionados[7].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[7].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[7].personagemPosicionado = true;
                        }
                        break;
                    case "L":
                        if (personagensPosicionados[8].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[8].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[8].personagemPosicionado = true;
                        }
                        break;
                    case "M":
                        if (personagensPosicionados[9].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[9].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[9].personagemPosicionado = true;
                        }
                        break;
                    case "Q":
                        if (personagensPosicionados[10].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[10].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[10].personagemPosicionado = true;
                        }
                        break;
                    case "R":
                        if (personagensPosicionados[11].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[11].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[11].personagemPosicionado = true;
                        }
                        break;
                    case "T":
                        if (personagensPosicionados[12].personagemPosicionado == false)
                        {
                            novaPosicaoPersonagem = posicaoSetor(60);
                            personagensPosicionados[12].cardPersonagem.Location = novaPosicaoPersonagem;
                            personagensPosicionados[12].personagemPosicionado = true;
                        }
                        break;
                }
            }

            return personagensPosicionados;
        }

        public bool personagemEstaPosicionado(List<Personagem> personagensRecebidos, char inicialPersonagem)
        {
            for (int i = 0; i < personagensRecebidos.Count; i++)
            {
                switch (inicialPersonagem)
                {
                    case 'A':
                        return personagensRecebidos[0].personagemPosicionado;
                    case 'B':
                        return personagensRecebidos[1].personagemPosicionado;
                    case 'C':
                        return personagensRecebidos[2].personagemPosicionado;
                    case 'D':
                        return personagensRecebidos[3].personagemPosicionado;
                    case 'E':
                        return personagensRecebidos[4].personagemPosicionado;
                    case 'G':
                        return personagensRecebidos[5].personagemPosicionado;
                    case 'H':
                        return personagensRecebidos[6].personagemPosicionado;
                    case 'K':
                        return personagensRecebidos[7].personagemPosicionado;
                    case 'L':
                        return personagensRecebidos[8].personagemPosicionado;
                    case 'M':
                        return personagensRecebidos[9].personagemPosicionado;
                    case 'Q':
                        return personagensRecebidos[10].personagemPosicionado;
                    case 'R':
                        return personagensRecebidos[11].personagemPosicionado;
                    case 'T':
                        return personagensRecebidos[12].personagemPosicionado;
                }
            }
            return false;
        }

        public Dictionary<int, string> atualizarEstadoTabuleiro(int idPartida, List<Personagem> personagensRecebidos)
        {
            string tabuleiroRecebido = Jogo.VerificarVez(idPartida);
            List<Personagem> personagensPosicionados = personagensRecebidos;
            tabuleiroRecebido.Replace("\r", "");
            string[] tabuleiroSala = tabuleiroRecebido.Split('\n');

            //Percorre todo estado do tabuleiro e atribui os valores
            for (int i = 1; i < tabuleiroSala.Length - 1; i++)
            {
                string[] personagemNoSetor = tabuleiroSala[i].Split(',');
                int setorPersonagemSelecionado = Convert.ToInt32(personagemNoSetor[0]);
                string nomePersonagemSelecionado = personagemNoSetor[1];
                bool posicaoSetorEstaDisponivel = true;
                switch (setorPersonagemSelecionado)
                {
                    case 0:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 0;
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 1 && setorPersonagemSelecionado <= 4)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);
                            if (setorPersonagemSelecionado >= 1 && setorPersonagemSelecionado <= 4)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 1:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 10;
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 11 && setorPersonagemSelecionado <= 14)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    setorPersonagemSelecionado = 1;
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);
                            if (setorPersonagemSelecionado >= 11 && setorPersonagemSelecionado <= 14)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 2:
                        //Verifica se o personagem esta posicionado
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 20;

                            //Verifica tem alguma posicao disponivel no setor
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 21 && setorPersonagemSelecionado <= 24)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);


                            //Atribui que o setor não esta mais disponivel e atribui qual a inicial do personagem esta no setor
                            if (setorPersonagemSelecionado >= 21 && setorPersonagemSelecionado <= 24)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 3:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 30;
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 31 && setorPersonagemSelecionado <= 34)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);
                            if (setorPersonagemSelecionado >= 31 && setorPersonagemSelecionado <= 34)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 4:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 40;
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 41 && setorPersonagemSelecionado <= 44)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);

                            if (setorPersonagemSelecionado >= 41 && setorPersonagemSelecionado <= 44)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 5:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 50;
                            do
                            {
                                setorPersonagemSelecionado++;
                                if (setorPersonagemSelecionado >= 51 && setorPersonagemSelecionado <= 54)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);
                            if (setorPersonagemSelecionado >= 51 && setorPersonagemSelecionado <= 54)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                    case 10:
                        if (personagemEstaPosicionado(personagensPosicionados, Convert.ToChar(nomePersonagemSelecionado.Substring(0, 1))) == false)
                        {
                            setorPersonagemSelecionado = 60;
                            do
                            {
                                if (setorPersonagemSelecionado == 60)
                                {
                                    posicaoSetorEstaDisponivel = verificarPosicaoSetorDisponivel(setorPersonagemSelecionado);
                                }
                                else
                                {
                                    break;
                                }
                            } while (posicaoSetorEstaDisponivel == true);
                            if (setorPersonagemSelecionado == 60)
                            {
                                setoresDisponiveis[setorPersonagemSelecionado] = true;
                                if (estadoSetorPersonagem[setorPersonagemSelecionado] == null)
                                {
                                    estadoSetorPersonagem[setorPersonagemSelecionado] = nomePersonagemSelecionado;
                                }
                            }
                        }
                        break;
                }
            }

            return estadoSetorPersonagem;
        }

        public Dictionary<int, string> LimparTabuleiro(Dictionary<int, string> estadoTabuleiro)
        {
            Dictionary<int, string> estadoTabuleiroRecebido = estadoTabuleiro;
            //Percorre todas as posições do tabuleiro e transforma em nulo o estado do tabuleiro
            for (int i = 1; i <= 4; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            for (int i = 11; i <= 14; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            for (int i = 21; i <= 24; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            for (int i = 31; i <= 34; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            for (int i = 41; i <= 44; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            for (int i = 51; i <= 54; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }
            setoresDisponiveis[60] = false;
            estadoTabuleiroRecebido[60] = null;

            return estadoTabuleiroRecebido;
        }

        public List<Personagem> LimparPosicaoDoPersonagem(List<Personagem> personagensRecebidos)
        {
            List<Personagem> listaDePersonagens = personagensRecebidos;
            //Limpa posição de todos os personagens
            for (int i = 0; i < listaDePersonagens.Count; i++)
            {
                switch (listaDePersonagens[i].nome)
                {
                    case "Adilson Konrad":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(26, 399);
                        break;
                    case "Beatriz Paiva":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(99, 399);
                        break;
                    case "Claro":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(99, 572);
                        break;
                    case "Douglas Baquiao":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(172, 486);
                        break;
                    case "Eduardo Takeo":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(172, 399);
                        break;
                    case "Guilherme Rey":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(172, 572);
                        break;
                    case "Heredia":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(327, 485);
                        break;
                    case "Kelly Kiyumi":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(245, 573);
                        break;
                    case "Leonardo Takuno":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(245, 486);
                        break;
                    case "Mario Toledo":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(26, 485);
                        break;
                    case "Quintas":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(245, 399);
                        break;
                    case "Ranulfo":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(26, 572);
                        break;
                    case "Toshio":
                        listaDePersonagens[i].personagemPosicionado = false;
                        listaDePersonagens[i].cardPersonagem.Location = new Point(99, 486);
                        break;
                }
            }
            return listaDePersonagens;
        }
    }

}
