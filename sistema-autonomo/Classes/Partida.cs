using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace sistema_autonomo.Classes
{
    public class Partida
    {
        private int id;
        private string nome;
        private string senha;
        private string data;
        private string status;

        public void SetID(int id)
        {
            this.id = id;
        }

        public int GetID()
        {
            return id;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public string GetData()
        {
            return data;
        }
        public void SetStatus(string status)
        {
            this.status = status;
        }
        public string GetStatus()
        {
            return status;
        }

    }
}
