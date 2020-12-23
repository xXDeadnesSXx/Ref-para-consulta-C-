using System;
using System.Collections.Generic;
using System.Text;

namespace Aula52Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { }
        public Produto(string nome, double preco, int quantidade)//inicio do construtor
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }//fim do construtor
        public Produto(string nome, double preco)//Sobrecarga do método Produto
        {
            Nome = nome;
            Preco = preco;
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
