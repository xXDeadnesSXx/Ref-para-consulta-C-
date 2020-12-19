using System;

namespace Aula70VetorDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto;
            Console.Write("N produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produtos[] vet = new Produtos[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write("Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Valor: R$  ");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine();
                produto = new Produtos(nome, preco);
                vet[i] = produto;
                Console.WriteLine();
                Console.WriteLine(produto);
                Console.WriteLine();
            }
            double soma = 0;
            for(int i = 0; i<vet.Length; i++)
            {
                soma += vet[i].Preco;
            }
            double media = soma / vet.Length;
            Console.WriteLine("Média: "+media.ToString("f2"));
        }
    }
}
