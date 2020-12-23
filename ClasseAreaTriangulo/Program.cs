using System;

namespace ClasseAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lados do triângulo 1:");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            double t1 = AreaTri(n1, n2, n3);
            Console.WriteLine("Área: " + t1);
            Console.Write("Lados do triângulo 2:");
            float n4 = float.Parse(Console.ReadLine());
            float n5 = float.Parse(Console.ReadLine());
            float n6 = float.Parse(Console.ReadLine());
            double t2 = AreaTri(n4, n5, n6);
            Console.WriteLine("Área: " + t2);
            if (t1 > t2)
            {
                Console.WriteLine("O primeiro triângulo é Maior");
            }
            else
            {
                Console.WriteLine("O segundo triângulo é Maior");
            }
            Console.WriteLine("_______________ Usando Classe _______________");
            Triangulo triangulo = new Triangulo();
            Triangulo triangulo2 = new Triangulo();
            Console.Write("Lados do triângulo 1:");
            triangulo.A = double.Parse(Console.ReadLine());
            triangulo.B = double.Parse(Console.ReadLine());
            triangulo.C = double.Parse(Console.ReadLine());
            Console.WriteLine(triangulo.Area());

            Console.Write("Lados do triângulo 2:");
            triangulo2.A = double.Parse(Console.ReadLine());
            triangulo2.B = double.Parse(Console.ReadLine());
            triangulo2.C = double.Parse(Console.ReadLine());
            Console.WriteLine(triangulo2.Area());
        }
        static double AreaTri(float a, float b, float c)
        {
            double area;
            float p;
            p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
    }
}
