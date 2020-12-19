using System;

namespace Aula75Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = i * 2;
            }
            foreach(int x in n)
            {
                Console.WriteLine(x);
            }
            string[] nomes = new string[6];
            for(int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = "Casa " + i.ToString();
            }
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
