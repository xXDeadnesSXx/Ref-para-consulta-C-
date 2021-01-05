using System;
using System.IO;

namespace Aula189StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string origem = @"C:\Users\Samsung ssg\source\repos\Aula189StreamWriter\Teste\arquivo1.txt";
            string destino = @"C:\Users\Samsung ssg\source\repos\Aula189StreamWriter\Teste\arquivo2.txt";
            try
            {
                string[] linhas = File.ReadAllLines(origem);//lê todas as linhas
                using (StreamWriter sw = File.AppendText(destino))//AppendText escreve no fim
                {
                    foreach(string linha in linhas)
                    {// vai criar um novo arquivo com o conteúdo igual a origem mas em letra maiúscula  
                        sw.WriteLine(linha.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: "+e);
            }
        }
    }
}
