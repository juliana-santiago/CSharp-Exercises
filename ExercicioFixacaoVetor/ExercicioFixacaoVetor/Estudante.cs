namespace ExercicioFixacaoVetor
{
    class Estudante
    {
        public int Quarto { get; private set; }
        public string Email { get; set; }
        public string Nome { get; set; }

        public Estudante(int quarto, string email, string nome)
        {
            Quarto = quarto;
            Email = email;
            Nome = nome;
        }

        public override string ToString()
        {
                return $"{Quarto}: {Nome}, {Email}";
        }

    }
}
