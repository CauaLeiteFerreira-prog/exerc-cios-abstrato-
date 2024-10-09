﻿namespace exercicio_03
{
    internal class Produto
    {

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Estoque { get; set; }


        public Produto(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void eStoque() 
        {
            Console.WriteLine($"temos {Estoque} no estoque");
        }
    }
}