using System;
using System.Collections.Generic;
using System.Text;

namespace Aula47Estaticos
{
    class Circunferencia
    {
        //Valor de Pi não varia logo usa static
        //Os metodos independem do objeto, não precisa intanciar a classe, logo static
        public static double Pi = 3.14;

        public static double Perimetro(double r)
        {
            return 2 * Pi * r;
        }
        public static double Area(double r)
        {
            return Pi * Math.Pow(r, 2);
        }

        public static double Volume(double r)
        {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}
