using System;

namespace Aula60ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Correntista corretista;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o nome do titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha=='s'||escolha=='S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = double.Parse(Console.ReadLine());
                corretista = new Correntista(conta, nome, valor);
            }
            else
            {
                corretista = new Correntista(conta, nome);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta");
            Console.WriteLine(corretista);
            
            Console.WriteLine();
            
            Console.Write("Quanto deseja depositar? ");
            double deposito = double.Parse(Console.ReadLine());
            corretista.Depositar(deposito);
            Console.WriteLine("Dados da conta");
            Console.WriteLine(corretista);

            Console.WriteLine();
            
            Console.Write("Quanto deseja sacar? ");
            double saque = double.Parse(Console.ReadLine());
            corretista.Sacar(saque);
            Console.WriteLine("Dados da conta");
            Console.WriteLine(corretista);
        }
    }
}
