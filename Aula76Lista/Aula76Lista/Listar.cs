using System;
using System.Collections.Generic;
using System.Text;

namespace Aula76Lista
{
    class Listar
    {
        public void Imp(List<string> l)
        {
            foreach (string nome in l)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine();
            Console.WriteLine("Total de elementos: " + l.Count);
            Console.WriteLine();
        }
    }
}
