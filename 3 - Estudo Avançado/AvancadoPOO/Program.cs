using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using AvancadoPOO._14___Interfaces.Entities;

namespace AvancadoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental  data : ");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

             CarRental car = new CarRental(start, finish, new Vehicle(model));

        }
        public static void Aula199() 
        {
            string path = @"E:\teste";
            try
            {

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }


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
        public static void Aula200() 
        {
            string path = @"E:\teste\file1.txt";
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension:  " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
    }
}
 