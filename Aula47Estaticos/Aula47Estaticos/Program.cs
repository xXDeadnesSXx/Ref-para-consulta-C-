using System;

namespace Aula47Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {//por serem metodos estáticos a chamada é feita direto da classe, sem instanciar
            Console.Write("Dig o raio:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimetro: " + Circunferencia.Perimetro(raio).ToString("f2"));
            Console.WriteLine("Área: " + Circunferencia.Area(raio).ToString("f2"));
            Console.WriteLine("Volume: " + Circunferencia.Volume(raio).ToString("f2"));
        }
    }
}
