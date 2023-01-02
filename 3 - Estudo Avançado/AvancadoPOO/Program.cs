using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Exercicio.Entities;
using AvancadoPOO._14___Interfaces.Entities;
using AvancadoPOO._14___Interfaces.Service;
using Exercicio.Service;

namespace AvancadoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Contract myContract;
                ContractService contractService;

                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int contractNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime contractData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double contractValue = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int numberInstallments = Convert.ToInt32(Console.ReadLine());

                myContract = new Contract(contractNumber, contractData, contractValue);
                contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(myContract, numberInstallments);

                Console.WriteLine("");
                Console.WriteLine("INSTALLMENTS: ");

                foreach (Installment installment in myContract.Installments)
                {
                    Console.WriteLine(installment);
                }


            }
            catch (Exception e) 
            {
                Console.WriteLine("Erro : " + e);
            
            }
     

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
        public static void Aula205() 
        {
            //SOLUÇÃO SEM INTERFACE

            Console.WriteLine("Enter rental  data : ");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTax());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
 