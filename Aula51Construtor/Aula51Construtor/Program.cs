using System;

namespace Aula51Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Dig. num. produtos add:");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Dig. num. produtos remover:");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
