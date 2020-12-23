using System;
using System.Globalization;

namespace Saida_e_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Fábio";
            int idade = 44;
            double salario = 30.578;
            Console.WriteLine(salario.ToString("f2"));
            //impressão com . na casa decimal deve ser inportado using using System.Globalization;
            Console.WriteLine(salario.ToString("f2", CultureInfo.InvariantCulture));
            //tecn. placeholder
            Console.WriteLine("Nome: {0} - Idade: {1} - Sálário: {2:f2}", nome, idade, salario);
            //tecn. interpolação
            Console.WriteLine($"Nome: {nome} - Idade: {idade} - Salário: {salario:f2}");
            //tecn. concatenação
            Console.WriteLine($"Nome: " + nome + " - Idade: " + idade + " - Salário: " + salario.ToString("f2"));
            Console.WriteLine("_____________________________");
            //Conversão implicita
            float a = 3.5f;
            double b = a;
            Console.WriteLine(b);
            //Não é permitido pela linguagem pois double tem 8 bytes e float 4 bytes
            /*
            double a1 = 3.5;
            float b1 = a1;
            */
            //Conversão explicita (casting)
            double a1 = 3.5;
            float b1 = (float)a1;
            Console.WriteLine(b1);
            //Conversão de float ou double para int é possível mas haverá 
            //perda da parte decimal
            float a3 = 3.9f;
            int i = (int)a3;
            Console.WriteLine(i);
            //Um float recebendo a Divisão de 2 int  - ERRADO
            int a4 = 5;
            int b4 = 2;
            float res = a4 / b4;
            Console.WriteLine(res);//retorna 2
            res = (float)a4 / b4;
            Console.WriteLine(res);//retorna 2,5 CORRETO
            //Entradas
            Console.Write("Digite seu nome:");
            string n1 = Console.ReadLine();
            Console.WriteLine(n1);
            //Quebrando uma string (Split)
            Console.WriteLine("Digite 3 numeros inteiros separados por espaço");
            string[] vet = Console.ReadLine().Split(" ");
            int x1 = int.Parse(vet[0]);
            int x2 = int.Parse(vet[1]);
            int x3 = int.Parse(vet[2]);
            Console.WriteLine("n 1: " + x1 + " - n 2: " + x2 + " - n 3: " + x3);
            if ((x1 > x2 &&  x1 > x3)
            {
                Console.WriteLine("O maior é o n 1: " + x1);
            }else if (x2 > x3)
            {
                Console.WriteLine("O maior é o n 2: " + x2);
            }
            else
            {
                Console.WriteLine("O maior é o n 3: " + x3);
            }
            Console.WriteLine("Digite o nome de 3 frutas separados por vírgula");
            string[] vet2 = Console.ReadLine().Split(",");
            Console.WriteLine(vet2[0]);
            Console.WriteLine(vet2[1]);
            Console.WriteLine(vet2[2]);
            //Recebendo números int, float e double
            Console.WriteLine("digite um número inteiro:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um número float:");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine(n2 + " - " + n3);


        }
    }
}
