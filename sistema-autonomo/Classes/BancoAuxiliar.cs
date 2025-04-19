using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
