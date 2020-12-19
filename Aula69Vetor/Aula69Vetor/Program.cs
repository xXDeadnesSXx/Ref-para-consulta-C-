using System;

namespace Aula69Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com a pos. " + i + " do vetor");
                vet[i] = double.Parse(Console.ReadLine());
            }
            double soma = 0;
            for(int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }
            Console.WriteLine(soma/vet.Length);
        }
    }
}
