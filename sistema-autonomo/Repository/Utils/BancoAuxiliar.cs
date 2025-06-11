﻿using KingMeServer;
using sistema_autonomo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo
{
    public static class BancoAuxiliar
    {
        //Trata os dados recebidos do servidor e retorna ele tratado
        public static string[] TratarDados(string dadosRecebidos) 
        {
            if(dadosRecebidos != "" && dadosRecebidos.Substring(0,1) != "E")
            {
                string[] dadosTratados;
                dadosRecebidos = dadosRecebidos.Replace("\r", "");
                dadosTratados = dadosRecebidos.Split('\n');
                return dadosTratados;
            }
            return null; //Retorna nulo caso dê erro;
        }
        
        //Vai para Partida
        public static string VerificarFase(int idPartida)
        {
            string[] dados = TratarDados(Jogo.VerificarVez(idPartida));
            string[] dadosPartida = dados[0].Split(',');
            string fasePartida = dadosPartida[dadosPartida.Length - 1];
            return fasePartida;
        }
        public static string VerificarRodada(int idPartida)
        {
            string fase = Jogo.VerificarVez(idPartida);
            fase = fase.Replace("\r\n", "");
            string[] Fase = fase.Split(',');

            //MessageBox.Show(Fase[2]);
            string n = Fase[2];
            return n;
        }


        public static string[] EstadoDoTabuleiro(int idPartida) {
            string tabuleiroRecebidoDll = Jogo.VerificarVez(idPartida);
            tabuleiroRecebidoDll.Replace("\r", "");
            string[] estadoDoTabuleiro = tabuleiroRecebidoDll.Split('\n');
            return estadoDoTabuleiro;
        }
    }
}
