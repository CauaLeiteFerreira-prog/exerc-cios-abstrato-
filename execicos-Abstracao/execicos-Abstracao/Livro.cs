namespace execicos_Abstracao
{
    internal class Livro
    {
        
            public string Titulo { get; set; }

            public string Autor { get; set; }

            public string Editora { get; set; }

            public int AnoLancamento { get; set; }

            //É necessario ter um metodo construtor paar acessar e manipular elas 
            public Livro(string nome, string autor, string editora, int ano)
            {
                Titulo = nome;
                Autor = autor;
                Editora = editora;
                AnoLancamento = ano;
            }
        }
}
