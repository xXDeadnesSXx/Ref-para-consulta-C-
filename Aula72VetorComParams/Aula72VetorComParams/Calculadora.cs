using System;
using System.Collections.Generic;
using System.Text;

namespace Aula72VetorComParams
{
    class Calculadora
    {
        public int Soma(params int[] n)
        {
            int soma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                soma += n[i];
            }
            return soma;
        }
        public int Triplo(int n)
        {
            n *= 3;
            return n;
        }
    }
}
