using System;
using System.IO;
namespace Aula186Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //LEMBRETE: Sempre chamar a biblioteca System.IO
            //caminho de origem do arquivo
            string soucePath = @"C:\Users\Samsung ssg\source\repos\Aula186Arquivos\arquivo teste\arquivo1.txt";
            //caminho de destino do arquivo
            string targetPath = @"C:\Users\Samsung ssg\source\repos\Aula186Arquivos\arquivo teste\arquivo2.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targetPath);//Faz uma cópia do arquivo para o destino especificado
                string[] lines = File.ReadAllLines(soucePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
                
                fs = new FileStream(targetPath, FileMode.Open);
                sr = new StreamReader(fs);
                string linha =  sr.ReadLine();
                string linha2 = sr.ReadToEnd();
                Console.WriteLine(linha);//lê a 1 linha
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally//Deve ser fechado obrigatoriamente
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
