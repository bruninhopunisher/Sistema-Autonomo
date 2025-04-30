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
        private const int DISTANCIA_ULTIMA_POSICAO = 3;
        //Partida partidaSelecionada;
        private Dictionary<int, Point> setoresPosicoes; // Mapeia setores para coordenadas X:Y
        private Dictionary<int, bool> setoresDisponiveis = new Dictionary<int, bool>
            {
                { 25, false },   // 6º
                { 21, false }, { 22, false }, { 23, false }, { 24, false },  // 5º
                { 17, false }, { 18, false }, { 19, false }, { 20, false },  // 4º
                { 13, false }, { 14, false }, { 15, false }, { 16, false },  // 3º
                { 9, false }, { 10, false }, { 11, false }, { 12, false },  // 2º
                { 5, false }, { 6, false }, { 7, false }, { 8, false },  // 1º
                {  1, false }, {  2, false }, {  3, false }, {  4, false }  // 0º
            };
        private Dictionary<int, string> estadoSetorPersonagem = new Dictionary<int, string>
            {
                { 25, null },   // 6º
                { 21, null }, { 22, null }, { 23, null }, { 24, null },  // 5º
                { 17, null }, { 18, null }, { 19, null }, { 20, null },  // 4º
                { 13, null }, { 14, null }, { 15, null }, { 16, null },  // 3º
                { 9, null }, { 10, null }, { 11, null }, { 12, null },  // 2º
                { 5, null }, { 6, null }, { 7, null }, { 8, null },  // 1º
                {  1, null }, {  2, null }, {  3, null }, {  4, null }  // 0º
            };
        public Tabuleiro()
        {
            // Mapeamento das coordenadas dos setores
            setoresPosicoes = new Dictionary<int, Point>
            {
                { 25, new Point(852, 36) },   // 6º
                { 21, new Point(752, 131) }, { 22, new Point(825, 131) }, { 23, new Point(898, 131) }, { 24, new Point(971, 131) },  // 5º
                { 17, new Point(738, 219) }, { 18, new Point(811, 219) }, { 19, new Point(889, 219) }, { 20, new Point(962, 219) },  // 4º
                { 13, new Point(738, 306) }, { 14, new Point(811, 306) }, { 15, new Point(889, 306) }, { 16, new Point(962, 306) },  // 3º
                { 9, new Point(738, 392) }, { 10, new Point(811, 392) }, { 11, new Point(889, 392) }, { 12, new Point(962, 392) },  // 2º
                { 5, new Point(738, 479) }, { 6, new Point(811, 479) }, { 7, new Point(889, 479) }, { 8, new Point(962, 479) },  // 1º
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
                    setor = 5;
                    for (int i = setor; i <= 8; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if(posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 2:
                    setor = 9;
                    for (int i = setor; i <= 12; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 3:
                    setor = 13;
                    for (int i = setor; i <= 16; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 4:
                    setor = 17;
                    for (int i = setor; i <= 20; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 5:
                    setor = 21;
                    for (int i = setor; i <= 24; i++)
                    {
                        posicaoDisponivel = verificarPosicaoSetorDisponivel(i);
                        if (posicaoDisponivel == false)
                            return posicaoDisponivel;
                    }
                    return posicaoDisponivel;
                case 10:
                    setor = 25;
                    posicaoDisponivel = verificarPosicaoSetorDisponivel(setor);
                    if (posicaoDisponivel == false)
                        return posicaoDisponivel;
                    return posicaoDisponivel;
            }
            return posicaoDisponivel;
        }
        public bool verificarPosicaoSetorDisponivel(int posicaoSetor)
        {
            return setoresDisponiveis[posicaoSetor];
        }
        public List<Personagem> posicionarPersonagem(Dictionary<int, string> estadoTabuleiro, List<Personagem> personagensRecebidos)
        {
            List<Personagem> personagensPosicionados = personagensRecebidos;
            Point novaPosicaoPersonagem;
            for (int i = 1; i <= 25; i++)
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
        public int VerificarPosicaoDisponivelNoSetor(int posicaoSetor)
        {
            int posicaoSetorRecebida = posicaoSetor;
            bool posicaoSetorEstaOcupada = true;
            do
            {
                if (posicaoSetorRecebida <= posicaoSetor + DISTANCIA_ULTIMA_POSICAO)
                {
                    posicaoSetorEstaOcupada = verificarPosicaoSetorDisponivel(posicaoSetorRecebida);
                    if(posicaoSetorEstaOcupada == true) 
                        posicaoSetorRecebida++;
                }
                else
                {
                    break;
                }
            } while (posicaoSetorEstaOcupada == true);
            return posicaoSetorRecebida;
        }
        public void ColocarPersonagemNaPosicaoDoSetor(int posicaoDisponivelNoSetor, string nomePersonagemSelecionado)
        {
            setoresDisponiveis[posicaoDisponivelNoSetor] = true;
            if (estadoSetorPersonagem[posicaoDisponivelNoSetor] == null)
            {
                estadoSetorPersonagem[posicaoDisponivelNoSetor] = nomePersonagemSelecionado;
            }
        }
        public int VerificarPrimeiraPosicaoDoSetor(int setor)
        {
            switch (setor)
            {
                case 0:
                    return 1;
                case 1: 
                    return 5;
                case 2:
                    return 9;
                case 3:
                    return 13;
                case 4:
                    return 17;
                case 5:
                    return 21;
                case 10:
                    return 25;
                default:
                    return -1;
            }
        }
        public Dictionary<int, string> atualizarEstadoTabuleiro(int idPartida, List<Personagem> personagensRecebidos)
        {
            string[] tabuleiroSala = BancoAuxiliar.EstadoDoTabuleiro(idPartida);
            List<Personagem> personagensPosicionados = personagensRecebidos;

            //Percorre todo estado do tabuleiro e atribui os valores
            for (int i = 1; i < tabuleiroSala.Length - 1; i++)
            {
                string[] personagemNoSetor = tabuleiroSala[i].Split(',');
                int setorPersonagemSelecionado = Convert.ToInt32(personagemNoSetor[0]);
                string nomePersonagemSelecionado = personagemNoSetor[1];//Arrumar substring 0,1
                
                int posicaoDisponivelNoSetor = VerificarPosicaoDisponivelNoSetor(VerificarPrimeiraPosicaoDoSetor(setorPersonagemSelecionado));
                ColocarPersonagemNaPosicaoDoSetor(posicaoDisponivelNoSetor, nomePersonagemSelecionado.Substring(0, 1));
            }

            return estadoSetorPersonagem;
        }
        public Dictionary<int, string> LimparTabuleiro(Dictionary<int, string> estadoTabuleiro)
        {
            Dictionary<int, string> estadoTabuleiroRecebido = estadoTabuleiro;
            //Percorre todas as posições do tabuleiro e transforma em nulo o estado do tabuleiro
            for (int i = 1; i <= 25; i++)
            {
                setoresDisponiveis[i] = false;
                estadoTabuleiroRecebido[i] = null;
            }

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
        public string VerificarPersonagemMaisAlto()
        {
            for (int i = 25; i > 1; i--)
            {
                if (estadoSetorPersonagem[i] != null)
                {
                    return estadoSetorPersonagem[i].Substring(0,1);
                }
            }
            return "Erro!";
        }
        public string VerificarPersonagemDaVotacao()
        {
            if (estadoSetorPersonagem[25].Substring(0, 1) != null)
                return estadoSetorPersonagem[25].Substring(0, 1);
            else
                return "Erro!";
        }
    }

}
