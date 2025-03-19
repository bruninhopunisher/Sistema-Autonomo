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

        public void setID(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return id;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setData(string data)
        {
            this.data = data;
        }

        public string getData()
        {
            return data;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public string getStatus()
        {
            return status;
        }

    }
}
