using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\source\repos\TiTpe21\UusSample\wishList";
            string userFile = "wishList";
            string fullFilePath = $@"{rootDirectory}\{userFile}.txt";

            string[] dataFromFile = File.ReadAllLines(fullFilePath);

            foreach(string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            
            Console.WriteLine();

            dataFromFile[0] = "pink unicorn";

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(fullFilePath, dataFromFile);
        }
    }
}
