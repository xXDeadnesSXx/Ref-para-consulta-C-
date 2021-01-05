using System;
using System.IO;

namespace Aula188BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Samsung ssg\source\repos\Aula186Arquivos\arquivo teste\arquivo1.txt";
            
            /*
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)//lê todas as linhas, EndOfStream enquanto não chega ao fim
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            */

            //Também pode ser feito dessa forma, em ambos os casos o 
            //using abre e fecha automaticamente
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)//lê todas as linhas, EndOfStream enquanto não chega ao fim
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
