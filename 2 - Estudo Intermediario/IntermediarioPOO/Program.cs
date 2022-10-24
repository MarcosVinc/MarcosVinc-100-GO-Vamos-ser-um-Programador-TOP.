using IntermediarioPOO.Entities;
using IntermediarioPOO.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;
using IntermediarioPOO.Entities.ExeercicioEC;
using IntermediarioPOO.Entities.ExeercicioEC.Enum;

namespace IntermediarioPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aula04();



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
        public static void Aula03()
        {
            //Post and Comments exercicio 02

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that´s, awesome!");
            PostUdemy p1 = new PostUdemy(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zealand",
                "I´m going to visit this wonderful country",
                12);
            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the dorce be with you");
            PostUdemy p2 = new PostUdemy(
                DateTime.Parse("28/07/2018 23:14:41"),
                "Good nisht guys",
                "See you tmorrow",
                12);
            p2.addComment(c3);
            p2.addComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


            /*
             //Post and Comments exercicio 02, FEITA INTEIRAMENTE POR MIM


             Post post;
             Comment comment;

             //Post
             Console.Write("Moment (DD/MM/YY) HH:mm:ss ");
             DateTime data = DateTime.Parse(Console.ReadLine());
             Console.Write("Digite o titulo do comentario: ");
             string title = Console.ReadLine();
             Console.WriteLine(" -- Digite o Corpo do texto --");
             Console.WriteLine();
             string content = Console.ReadLine();
             Console.WriteLine("-------------------------------");
             Console.Write("Likes: ");
             int likes = Convert.ToInt32(Console.ReadLine());

             post = new Post(data, title,content,likes);

             Console.Write("Quantos comentarios vc quer fazer ao post acima ? ");
             int n = Convert.ToInt32(Console.ReadLine());

             for (int p = 1; p <= n; p++) 
             {
                 Console.WriteLine();
                 Console.WriteLine("Caixa de comentario");
                 Console.WriteLine();
                 string comentario = Console.ReadLine();
                 comment = new Comment(comentario);
                 post.addComment(comment);             
             }

             Console.WriteLine();
             Console.WriteLine($" -----{post.Title}-------");
             Console.WriteLine("--------------------------");
             Console.WriteLine($"{post.Likes} Likes - {post.Moment}");
             Console.WriteLine("---------------------------");
             Console.WriteLine(post.Content);
             Console.WriteLine("---------------------------");
             Console.WriteLine();

             foreach (Comment obj in post.Comments) 
             {
                 Console.WriteLine("Comments");
                 Console.WriteLine(obj.Text);
                 Console.WriteLine();
             } */

        }
        public static void Aula04() 
        {
            Client client;
            Ordert order;
            Productt prod;


            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            DateTime dateMoment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatust OrderEnum = Enum.Parse<OrderStatust>(Console.ReadLine());
            client = new Client(name, email, dateBirth);
            order = new Ordert(dateMoment, OrderEnum, client);
            Console.WriteLine();
            Console.Write("Hoe many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityProduct = Convert.ToInt32(Console.ReadLine());
                prod = new Productt(nameProduct, priceProduct);
                
                OrderItem list = new OrderItem(quantityProduct, priceProduct, prod);
                order.addItem(list);
            }
            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}
