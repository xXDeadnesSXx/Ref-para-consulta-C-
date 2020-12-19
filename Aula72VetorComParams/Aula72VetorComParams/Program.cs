using System;

namespace Aula72VetorComParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            int total = c.Soma(1, 3, 5,9,18);
            Console.WriteLine(total);

            Console.WriteLine(c.Triplo(6));
        }
    }
}
