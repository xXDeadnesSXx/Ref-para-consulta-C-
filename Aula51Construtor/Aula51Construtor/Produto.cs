﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula51Construtor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("f2")
                + ", " + Quantidade + " unidades, "
                + "Valor total em estoque R$ "
                + ValorTotalEmEstoque().ToString("f2");
        }
    }
}
