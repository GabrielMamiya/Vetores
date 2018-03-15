using System;
namespace vetores
{
    public class Quartos
    {

        public string nome { get; private set; }
        public string email { get; private set; }
        public int quarto { get; private set; }

        public Quartos(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public override string ToString()
        {
            return nome + ", " + email;
        }
            

    }
}
