using Estudos.Entities;
using System;
using System.Globalization;
using System.IO;
namespace Estudos
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Qual o caminho do arquivo: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = sourceFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {
                        string [] camp = line.Split(',');
                        string name = camp[0];
                        double price = double.Parse(camp[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(camp[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + ", " + prod.Total().ToString("F2", CultureInfo.InvariantCulture));

                        sw.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("there was an error: ");
                Console.WriteLine(e.Message);
            }

        }

    }
}