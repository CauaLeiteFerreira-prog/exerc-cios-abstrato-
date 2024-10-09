using execicos_Abstracao;

Livro livro1 = new Livro("Metamorfose", " Franz Kafka", "Editora Rígel", 1915);
Livro livro2 = new Livro("de volta ao jogo", "rezendeEvil ", "Suma", 2016);
Livro livro3 = new Livro("Como enfrentar o odio", " Felipe Neto", "Pixel", 2024);

Console.WriteLine("o livro escolhido é: " + livro1.Titulo + " do autor " + livro1.Autor + ", pubicado pela " + livro1.Editora + " em " + livro1.AnoLancamento);
Console.WriteLine("o livro escolhido é: " + livro2.Titulo + " do autor " + livro2.Autor + ", pubicado pela editora " + livro2.Editora + " em " + livro2.AnoLancamento);
Console.WriteLine("o livro escolhido é: " + livro3.Titulo + " do autor " + livro3.Autor + ", pubicado pela editora " + livro3.Editora + " em " + livro3.AnoLancamento);

Console.ReadKey();