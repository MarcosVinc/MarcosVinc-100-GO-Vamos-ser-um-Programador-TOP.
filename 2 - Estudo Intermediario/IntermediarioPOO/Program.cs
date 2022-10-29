using IntermediarioPOO.Entities;
using IntermediarioPOO.Entities.Enums;
using System.Globalization;
using System;
using System.Collections.Generic;
using IntermediarioPOO.Entities.ExeercicioEC;
using IntermediarioPOO.Entities.ExeercicioEC.Enum;
using IntermediarioPOO._10_Herança_e_Polimorfismo;
using IntermediarioPOO._10_Herança_e_Polimorfismo._135___Herença;
using IntermediarioPOO._10_Herança_e_Polimorfismo._136___Upcasting_e_downcasting;
using IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._140;
using IntermediarioPOO._10_Herança_e_Polimorfismo._140__a_142___Exercicios._142;
using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_144___Classes_e_Metodos_Abstratos.Exercicios_Abstrato;
using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_144___Classes_e_Metodos_Abstratos.Exercicios_Abstrato.Entities;
using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146____Exercicio_Abastrato;
using IntermediarioPOO._10_Herança_e_Polimorfismo._143_a_146___Classes_e_Metodos_Abstratos._146___Exercicio.Entities;

namespace IntermediarioPOO
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        #region Enumeraçãoes e Composição
        public static void AulaApresentacao()
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
        public static void Exercicio01()
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
        public static void Exercicio02()
        {

          #region Post and Comments Com "Ajuda do professor"

            /*
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
              Console.WriteLine(p2);*/

            #endregion

          #region Post and Comments exercicio 02, FEITA INTEIRAMENTE POR MIM




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
             Console.WriteLine(post.Title);
             Console.WriteLine($"{post.Likes} Likes - {post.Moment}");
             Console.WriteLine(post.Content);
             Console.WriteLine();

             foreach (Comment obj in post.Comments) 
             {
                 Console.WriteLine("Comments");
                 Console.WriteLine(obj.Text);
                 Console.WriteLine();
             }
#endregion

        }
        public static void Exercicio03() 
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
        #endregion

        #region Herança e Polimorfismo

        public static void UpcastingEDownCasting() 
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 2000.0);
            Account acc3 = new SavingsAccont(1003, "Anna", 1000.00, 10);

            //DownCasting (opção insegura)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount) acc3;

            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccont)
            {
                //SavingsAccont acc5 = (SavingsAccont) acc3;
                SavingsAccont acc5 = acc3 as SavingsAccont;
                acc5.updateBalance();
                Console.WriteLine("Update!");
            }

        }
        public static void SobreposicaoOuSobrescrita() 
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccont(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine("ACC1:" + acc1.Balance + ",  ACC2: " + acc2.Balance);
        }
        public static void ClassesEMetodosSelados()
        {

            //            Pra quê?
            //• Segurança: dependendo das regras do negócio, às vezes é desejável
            //garantir que uma classe não seja herdada, ou que um método não
            //seja sobreposto.
            //• Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
            //podem ser uma porta de entrada para inconsistências
            //• Performance: atributos de tipo de uma classe selada são analisados
            //de forma mais rápida em tempo de execução.
            //• Exemplo clássico: string


        }

        public static void Exercicio140() 
        {
            List<Employee> list = new List<Employee>();
            string name;
            int hours;
            double valueperhours;


            Console.Write("Quantos funcionarios você quer adicionar a empresa: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n) ?");
                string esc = Console.ReadLine();
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Hours: ");
                hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Valur per Hours: ");
                valueperhours = Convert.ToDouble(Console.ReadLine());

                if (esc.ToLower() == "s" || esc.ToLower() == "y")
                {
                    Console.Write("Additional charge: ");
                    double add = Convert.ToDouble(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valueperhours, add));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhours));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $: {emp.payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
        public static void Exercicio142() 
        {
            List<Product> listProd = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                //
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char esc = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double preço = Convert.ToDouble(Console.ReadLine());
                //

                if (esc == 'c')
                {
                    listProd.Add(new Product(nome, preço));
                }
                else if (esc == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    listProd.Add(new UsedProduct(nome, preço, data));
                }
                else if (esc == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = Convert.ToDouble(Console.ReadLine());
                    listProd.Add(new ImportedProduct(nome, preço, fee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product obj in listProd)
            {
                Console.WriteLine($"{obj.priceTag()}");
            }

        }
        public static void Exercicio145() 
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine();
                Console.WriteLine("Shape #" + j + " data: ");
                Console.Write("Rectangle of Circle (r/c)? ");
                char rc = Convert.ToChar(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (rc == 'r' || rc == 'R')
                {
                    Console.Write("Width: ");
                    double widht = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    list.Add(new Rectangle(color, widht, height));
                }
                else if (rc == 'c' || rc == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    list.Add(new Circle(color, radius));

                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.area().ToString("f2", CultureInfo.InvariantCulture));
            }

        }
        public static void Exercicio146() 
        {
            List<Contribuintes> list = new List<Contribuintes>();


            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char indComp = Convert.ToChar(Console.ReadLine());
                if (indComp == 'i' || indComp == 'I')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double ganhoAnual = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double gastoMedico = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(nome, ganhoAnual, gastoMedico));
                }
                else if (indComp == 'c' || indComp == 'C')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double ganhoAnual = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int nEmpregados = Convert.ToInt32(Console.ReadLine());
                    list.Add(new Empresa(nome, ganhoAnual, nEmpregados));

                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;

            foreach (Contribuintes obj in list)
            {
                Console.WriteLine($"{obj.Nome}: $ {obj.Taxa().ToString("f2", CultureInfo.InvariantCulture)}");
            }

            foreach (Contribuintes obj in list)
            {

                sum += obj.Taxa();
            }
            Console.WriteLine();
            Console.Write($"TOTAL TAXES: {sum.ToString("f2", CultureInfo.InvariantCulture)}");


        }


        #endregion
    }
}
