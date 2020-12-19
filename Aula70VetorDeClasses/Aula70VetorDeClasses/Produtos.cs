﻿namespace Aula70VetorDeClasses
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return "Produto: " + Nome
                + " - Preço: R$ " + Preco.ToString("f2");
        }
    }
}
