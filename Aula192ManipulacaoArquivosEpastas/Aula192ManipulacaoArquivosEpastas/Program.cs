using System;
using System.IO;
using Aula192ManipulacaoArquivosEpastas.Entities;
using System.Globalization;

namespace Aula192ManipulacaoArquivosEpastas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exemplo 1: Checa se existe ou cria um arquivo de texto simples na pasta temporária
            //Pega a caminho da pasta temp da máquina
            string pastaTemporaria = Path.GetTempPath();
            Console.WriteLine(pastaTemporaria);
            //concatena aa strings para criar o caminho como o local e o nome do arquivo
            string path = pastaTemporaria + "delmenow.txt";
            Console.WriteLine(path);

            try
            {
                //Testa se o arquivo delmenow.txt existe e caso não exista cria o arquivo
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine("Arquivo não existe e será criado");
                        sw.WriteLine("Hello");
                        sw.WriteLine("and");
                        sw.WriteLine("Welcome");
                    }
                }

                Console.WriteLine("O conteudo do arquivo é");
                using (StreamReader sr = File.OpenText(path))
                {//armazena na variável temporária s o conteúdo do arquivo e imprime as linhas
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e);
            }
            */
            //Exemplo 2: Analiza um arquivo e cria um novo manipulando os dados de origem
            string pastaTemp = Path.GetTempPath();
            //Cria uma subpasta na pasta temporária
            Directory.CreateDirectory(pastaTemp + "PastaTeste");
            string origem = pastaTemp + "PastaTeste";//caminho para a pasta de origem
            Directory.CreateDirectory(origem + @"\out");//cria a subpasta out dentro da PastaTeste
            string path = origem + @"\origem.csv";//caminho para o arquivo de origem
            string destino = origem + @"\out\summary.csv";//caminho para o arquivo de destino
            Console.WriteLine("Caminho da pasta de origem: " + origem);
            Console.WriteLine("Caminho da pasta de destino: " + destino);
            Console.WriteLine("Arquivo original: " + path);
            try
            {
                using (StreamWriter sw = File.CreateText(path))//cria o arquivo de origem
                {
                    sw.WriteLine("TV Led,1290.99,1");
                    sw.WriteLine("Video Game Chair,350.00,3");
                    sw.WriteLine("Iphone X,900.00,2");
                    sw.WriteLine("Samsung Galaxy 9,850.00,2");
                }
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                using (StreamWriter sw2 = File.AppendText(destino))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product p = new Product(name, price, quantity);
                        sw2.WriteLine(p.Name + "," + p.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
                string[] linesRes = File.ReadAllLines(destino);
                foreach (string line in linesRes)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e);
            }
        }
    }
}
