namespace sistema_autonomo.Classes
{
    public abstract class Jogador
    {
        protected int id;
        protected string nome;
        protected int qtdPonto;
        protected int qtdNao;
        public Jogador(int id, string nome, int ponto, int qtdeNao)
        {
            this.id = id;
            this.nome = nome;
            this.qtdPonto = ponto;
            this.qtdNao = qtdeNao;
        }
        public int Id
        {
            get { return this.id; }
        }
        public string Nome
        {
            get { return this.nome; }
        }
        public int QtdPonto
        {
            get { return this.qtdPonto; }
            set { this.qtdPonto = value; }
        }
        public int QtdNao
        {
            get { return this.qtdNao; }
            set { this.qtdNao = value; }
        }
    }
}
