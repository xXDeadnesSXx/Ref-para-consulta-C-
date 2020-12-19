using System;

namespace Aula79Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 3];//Cria uma matriz de 2 linhas e 3 colunas, o tamanho deve ser indicado
            Console.WriteLine("Posições da matriz: " + matriz.Length);//Tamanho da matriz
            Console.WriteLine("N de linhas da matriz: " + matriz.Rank);//Dimensão da matriz, no caso bidimenssiona
            Console.WriteLine("Total de linhas: " + matriz.GetLength(0));//quantidade de linhas
            Console.WriteLine("Total de colunas: " + matriz.GetLength(1));//quantidade de colunas
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Dimensões da matriz quadrada(lados = colunas): ");
            int n = int.Parse(Console.ReadLine());
            int[,] num = new int[n, n];
            
            Console.WriteLine("Entre com os números da 1 linha separados por espaço: ");
            string[] l1 = Console.ReadLine().Split(" ");
            num[0, 0] = int.Parse(l1[0]);
            num[0, 1] = int.Parse(l1[1]);
            num[0, 2] = int.Parse(l1[2]);

            Console.WriteLine("Entre com os números da 2 linha separados por espaço: ");
            string[] l2 = Console.ReadLine().Split(" ");
            num[1, 0] = int.Parse(l2[0]);
            num[1, 1] = int.Parse(l2[1]);
            num[1, 2] = int.Parse(l2[2]);

            Console.WriteLine("Entre com os números da 1 linha separados por espaço: ");
            string[] l3 = Console.ReadLine().Split(" ");
            num[2, 0] = int.Parse(l3[0]);
            num[2, 1] = int.Parse(l3[1]);
            num[2, 2] = int.Parse(l3[2]);

            foreach(int pos in num)
            {
                Console.WriteLine(pos);
            }
        }
    }
}
