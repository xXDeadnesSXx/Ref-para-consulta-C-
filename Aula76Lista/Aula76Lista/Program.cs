using System;
using System.Collections.Generic;

namespace Aula76Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Listar listar;
            List<string> livros = new List<string>();//vazia
            List<string> nomes = new List<string> { "Fábio", "João" };//inicializada

            nomes.Add("Maria");//adcionou um novo item a lista
            listar = new Listar();
            listar.Imp(nomes);

            nomes.Insert(1, "Pedro");//adciona na lista na posição especificada
            listar.Imp(nomes);

            nomes.Add("Juca");
            listar.Imp(nomes);
            string s1 = nomes.Find(x => x[0] == 'J');//expressão lâmbida x tal que o primeiro caracter seja J
            string s2 = nomes.FindLast(x => x[0] == 'J');//mesma expressão sendo que FindLast pega o último
            Console.WriteLine();
            Console.WriteLine("Primeiro que começa com J: " + s1);
            Console.WriteLine("Último que começa com J: " + s2);

            nomes.Add("Fernando");
            listar.Imp(nomes);
            int p1 = nomes.FindIndex(x => x[0] == 'F');//primeiro index que começa com F
            int p2 = nomes.FindLastIndex(x => x[0] == 'F');//último index que começa com F
            Console.WriteLine();
            Console.WriteLine("Primeiro index que começa com F: " + p1);
            Console.WriteLine("Último index que começa com F: " + p2);

            //Filtrar lista
            Console.WriteLine();

            List<string> filtro = nomes.FindAll(x => x.Length == 5);//Cria uma listar cujo os elementos têm 4 caracteres
            listar.Imp(filtro);
            //fim
            //Remover itens
            nomes.Add("Sr. Me Deleta");
            listar.Imp(nomes);
            nomes.Remove("Sr. Me Deleta");
            listar.Imp(nomes);
            Console.WriteLine("------------------------------------------------------");
            nomes.RemoveAll(x => x[0] == 'F');//Remove todos os itens que começão com F
            listar.Imp(nomes);
            Console.WriteLine("------------------------------------------------------");
            nomes.RemoveAt(2);
            listar.Imp(nomes);
            Console.WriteLine("------------------------------------------------------");
            nomes.RemoveRange(0, 2);//remove 2 elementos a partir do index 0 inclusive
            listar.Imp(nomes);
            Console.WriteLine("------------------------------------------------------");







        }
    }
}
