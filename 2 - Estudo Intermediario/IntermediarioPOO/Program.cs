using IntermediarioPOO.Entities;
using IntermediarioPOO.Entities.Enums;
using System.Globalization;
using System;

namespace IntermediarioPOO
{
    class Program
    {
        static void Main(string[] args)
        {





        }


        public static void Aula01()
        {
            //Por dentro da ENUM

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment,


            };

            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();
            Console.WriteLine(txt);
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine();
            Console.WriteLine(os);
        }
        public static void Aula02()
        {
            //Composição de objetos exercicio 01


            Departament departament;
            Worker worker;

            Console.Write("Ender departament´s name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base salary: ");
            double bSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


            departament = new Departament(dptName);
            worker = new Worker(name, level, bSalary, departament);

            Console.Write("How many contracts to this worker? ");
            int contractNumberS = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contractNumberS; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #" + i + " contract data: ");
                Console.Write("Date (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = Convert.ToInt32(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);

            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = Convert.ToInt32(monthAndYear.Substring(0, 2));
            int year = Convert.ToInt32(monthAndYear.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
