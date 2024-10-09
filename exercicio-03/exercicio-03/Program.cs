using exercicio_03;

Produto pro1 = new Produto(2468,"copo", 7.50, 12);
Produto pro2 = new Produto(1488, "celular", 1800, 300);
Produto pro3 = new Produto(3698, "vioão", 1200, 120);

Console.WriteLine("\nproduto: " +pro1.Nome+ "\ncodigo: " +pro1.Codigo+ "\ncusto: " +pro1.Preco);
pro1.eStoque();

Console.WriteLine("\nproduto: " + pro2.Nome + "\ncodigo: " + pro2.Codigo + "\ncusto: " + pro2.Preco);
pro2.eStoque();

Console.WriteLine("\nproduto: " + pro3.Nome + "\ncodigo: " + pro3.Codigo + "\ncusto: " + pro3.Preco);
pro3.eStoque();

Console.ReadKey();