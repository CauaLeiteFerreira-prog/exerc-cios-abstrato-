namespace exercicio_2
{
    internal class Aluno
    {
        public int Rm { get; set; }

        public string Nome { get; set; }

        public DateOnly Nascimento { get; set; }

        public string Email { get; set; }


        public Aluno(int rm, string nome, DateOnly nascimento, string email)
        {
            Rm = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }
    
            
    }
}
