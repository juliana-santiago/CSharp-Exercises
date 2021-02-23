using System;
using System.IO;

namespace FinallyAndFileStreamDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open); //Substituir o caminho  pelo caminho da pasta que desejar e para testar o try basta criar um arquivo no local da pasta e escrever algo na primeira linha
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    Console.WriteLine("\nArquivo fechado com sucesso!");
                }
                else
                {
                Console.WriteLine("\nArquivo inexistente!");
                }
            }
        }
    }
}
