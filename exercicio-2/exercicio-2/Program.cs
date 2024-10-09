using exercicio_2;

Aluno aluno1 = new Aluno(2468, "Thiago", new DateOnly  (2005,9,10), "thiago.alvez9@portalsesisp.org.br");
Aluno aluno2 = new Aluno(1796, "Cauã", new DateOnly (2006,09,07), "caua.ferriera@portalsesisp.org.br");
Aluno aluno3 = new Aluno(2468, "Victor Hugo", new DateOnly (2007,7,20), "victor.santos@portalsesisp.org.br");

Console.WriteLine("o rm do aluno é: " + aluno1.Rm + " com o nome: " + aluno1.Nome + ", nasceu em: " + aluno1.Nascimento + " e possue esse email: " + aluno1.Email);
Console.WriteLine("o rm do aluno é: " + aluno2.Rm + " com o nome: " + aluno2.Nome + ", nasceu em: " + aluno2.Nascimento + " e possue esse email: " + aluno2.Email);
Console.WriteLine("o rm do aluno é: " + aluno3.Rm + " com o nome: " + aluno3.Nome + ", nasceu em: " + aluno3.Nascimento + " e possue esse email: " + aluno3.Email);

Console.ReadKey();