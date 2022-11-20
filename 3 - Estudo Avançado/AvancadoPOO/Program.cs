using System;
using System.IO;

namespace AvancadoPOO
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        public static void Aula195() 
        {
            string sourcePath = @"E:\teste\file1.txt";
            string targetPath = @"E:\teste\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.Write("Um erro aconreceu: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
