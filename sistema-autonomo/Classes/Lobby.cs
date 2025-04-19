using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace sistema_autonomo.Classes
{
    public class Lobby
    {
        public static string nomeGrupo { get { return "Estudantes de Bolonha";  } }

        public static string GetNomeGrupo()
        {
            return nomeGrupo;
        }
        public static string[] ListarPartidas()
        {
            string listaDePartidas = Jogo.ListarPartidas("T");
            listaDePartidas = listaDePartidas.Replace("\r", "");
            string[] partidas = listaDePartidas.Split('\n');
            return partidas;
        }
        public static string CriarPartida(string nomePartida, string senhaPartida, string nomeGrupo)
        {
            if (nomePartida == "" || nomePartida == null)
            {
                return "ERRO: informe o nome da partida";
            }
            else if (senhaPartida == "" || senhaPartida == null)
            {
                return "ERRO: informe a senha da partida";
            }
            if (nomePartida.Length > 20)
            {
                return "ERRO:Nome da partida com mais que 20 caracteres";
            }

            if (senhaPartida.Length > 10)
            {
                return "ERRO:Senha com mais do que 10 caracteres";
            }
            else
            {
                string idPartidaCriada = Jogo.CriarPartida(nomePartida, senhaPartida, nomeGrupo);
                return $"Partida criada com sucesso!\nO ID da sua partida é {idPartidaCriada}";
            }
        }
        public static string[] EntrarPartida(Partida partidaSelecionada, string nomeJogador, string senhaJogador)
        {
            string[] dadosJogador = new string[2];
            string dadosRecebidos = Jogo.Entrar(partidaSelecionada.Id, nomeJogador, senhaJogador);

            if(dadosRecebidos.Substring(0,4) == "ERRO")
            {
                dadosJogador = dadosRecebidos.Split(':');
            }
            else
            {
                dadosJogador = dadosRecebidos.Split(',');
            }
            return dadosJogador;
        }
        public static string[] ListarJogadores(Partida partidaSelecionada)
        {
            string jogadoresRecebidos = Jogo.ListarJogadores(partidaSelecionada.Id);
            jogadoresRecebidos = jogadoresRecebidos.Replace("\r", "");
            string[] jogadores = jogadoresRecebidos.Split('\n');
            return jogadores;
        }
    }
}
