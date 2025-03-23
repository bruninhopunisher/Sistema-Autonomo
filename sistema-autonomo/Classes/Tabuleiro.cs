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
    using System.Windows.Forms;
    using KingMeServer;

    public class Tabuleiro
    {
        Partida partidaSelecionada;
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

        public bool verificarSetorDisponivel(int posicaoSetor)
        {
            return setoresDisponiveis[posicaoSetor];
        }
    }

}
