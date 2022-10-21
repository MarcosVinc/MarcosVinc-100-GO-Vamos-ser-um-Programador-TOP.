using BasicoPOO.Entities.Classes;
using BasicoPOO.Entities.Contrutores_e_Encapsulamento;
using BasicoPOO.Entities.Listas;
using BasicoPOO.Entities.Vetores;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BasicoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaInicial();
        }


        #region Telas
        public static void TelaInicial()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("| 1 - Estrutura Repetitiva WHILE");
            Console.WriteLine("| 2 - Estrutura Repetitiva FOR");
            Console.WriteLine("| 3 - Estrutura Repetitiva IF, ELSE");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        Console.Clear();
                        TelaWhile();
                        break;
                    case 2:
                        Console.Clear();
                        TelaFor();
                        break;
                    case 3:
                        Console.Clear();
                        TelaIF();
                        break;

                }
            }
        }
        public static void TelaIF()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        break;

                }
            }


        }
        public static void TelaWhile()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            int esc = 0;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        Console.Clear();
                        ExercicioWhile1();
                        break;
                    case 2:
                        Console.Clear();
                        ExercicioWhile2();

                        break;

                }
            }
        }
        public static void TelaFor()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Exercicio 1 ");
            Console.WriteLine("2 - Exercicio 2 ");
            Console.WriteLine("3 - Exercicio 3 ");
            Console.WriteLine("4 - Exercicio 4 ");
            Console.WriteLine("--------------------");
            Console.WriteLine("PROXIMA PAGINA APERTE 0");
            int esc = 089;
            if (int.TryParse(Console.ReadLine(), out esc))
            {
                switch (esc)
                {
                    case 1:
                        Console.Clear();
                        ExercicioFor1();
                        break;
                    case 2:
                        Console.Clear();
                        ExercicioFor2();
                        break;
                    case 3:
                        Console.Clear();
                        ExercicioFor3();
                        break;
                    case 4:
                        Console.Clear();
                        ExercicioFor4();
                        break;
                    case 5:
                        Console.Clear();
                        ExercicioFor5();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Pagina ainda não criada, aperte entrer para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        TelaFor();
                        break;

                }
            }
        }
        #endregion

        #region Exercícios sobre Estrutura Repetitiva WHILE

        public static void ExercicioWhile1()
        {
            Console.WriteLine("Digite a senha: ");
            var senha = 0.0;
            if (double.TryParse(Console.ReadLine(), out senha))
            {
                while (senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                    senha = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Acesso Permitido");
            }
            else
            {
                Console.WriteLine("Valor não reconhecido, Precione qualquer tecla para voltar");
                Console.ReadLine();
                Console.Clear();
                ExercicioWhile1();
            }
        }

        public static void ExercicioWhile2()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("|1.Álcool             |");
            Console.WriteLine("|2.Gasolina           |");
            Console.WriteLine("|3.Diesel             |");
            Console.WriteLine("|4.Fim                |");
            Console.WriteLine("-----------------------");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            var PostoGama = 0;
            if (int.TryParse(Console.ReadLine(), out PostoGama))
            {
                while (PostoGama != 4)
                {
                    if (PostoGama == 1)
                    {
                        alcool++;
                    }
                    else if (PostoGama == 2)
                    {
                        gasolina++;
                    }
                    else if (PostoGama == 3)
                    {
                        diesel++;
                    }
                    PostoGama = Convert.ToInt32(Console.ReadLine());
                }


            }
            else
            {
                Console.WriteLine("Nenhum numero foi reconhecido, por favor digite qualquer tecla para voltar a tela inicial");
                Console.ReadLine();
                Console.Clear();
                ExercicioWhile2();
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
        #endregion

        #region Exercícios sobre Estrutura Repetitiva FOR

        public static void ExercicioFor1()
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = Convert.ToInt32(Console.ReadLine());
            int SomaFinal = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int Soma = Convert.ToInt32(Console.ReadLine());
                //SomaFinal = SomaFinal + Soma;
                SomaFinal += Soma;
            }
            Console.WriteLine("Soma = " + SomaFinal);
        }

        public static void ExercicioFor2()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }

        }

        public static void ExercicioFor3()
        {
            Console.Write("Quantidade: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int _in = 0;
            int _out = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Valor: ");
                int cont = Convert.ToInt32(Console.ReadLine());

                if (cont >= 10 && cont < 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }


            }
            Console.WriteLine($"{_in}in");
            Console.WriteLine($"{_out}out");

        }
        public static void ExercicioFor4()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine();
                Console.WriteLine("-----------");
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("-----------");
                Console.WriteLine();



            }


        }
        public static void ExercicioFor5()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void ExercicioFor6()
        {
            double soma = 0.0;
            double j = 0.0;
            for (j = 1; j <= 10; j++)
            {
                soma += j;
                Console.WriteLine("#{0}", j);


            }

            Console.WriteLine("A Soma é :" + soma);

        }
        public static void Exercicio7() { }
        // public static void Exercicio() { }


        #endregion

        #region Estudo de Classes
        public static void EstudoDeClasse()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = Convert.ToDouble(Console.ReadLine());
            x.B = Convert.ToDouble(Console.ReadLine());
            x.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = Convert.ToDouble(Console.ReadLine());
            y.B = Convert.ToDouble(Console.ReadLine());
            y.C = Convert.ToDouble(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X:" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y:" + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }


        }
        public static void ClasseProduto()
        {

            int quantidadeAdicionar = 0;
            int quantidadeRetirada = 0;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Entrada no ESTOQUE: ");
            quantidadeAdicionar = Convert.ToInt32(Console.ReadLine());
            p.AdicionarProdutos(quantidadeAdicionar);
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.Write("Entre com as Unidades para retirada: ");
            quantidadeRetirada = Convert.ToInt32(Console.ReadLine());
            p.RemoverProdutos(quantidadeRetirada);
            Console.WriteLine("Estoque atualizado: " + p);
            Console.WriteLine("----------------------------");




        }
        public static void Retangulo()
        {
            Retangulo ret;
            ret = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            Console.Write("Largura: ");
            ret.Largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            ret.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ret);

        }
        public static void Funcionario()
        {
            Funcionario fun;
            fun = new Funcionario();
            double porcentagem = 0.0;
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o importo sobre o salario: ");
            fun.Imposto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(fun);
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            porcentagem = Convert.ToDouble(Console.ReadLine());
            fun.AumentarSalario(porcentagem);
            Console.WriteLine($"Dados atualizados: " + fun); ;

        }
        public static void Escola()
        {
            BeneditoEscola be;
            be = new BeneditoEscola();

            Console.Write("Nome do aluno: ");
            be.NOME = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            be.NOTAPRIMEIROTREMESTRE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------");
            be.NOTASEGUNGOTREMESTRE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------");
            be.NOTATERCEIROTREMESTRE = Convert.ToDouble(Console.ReadLine());

            double notaFinal = be.NotaFinal();

            if (notaFinal < 60)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                double faltam = 60 - notaFinal;
                Console.WriteLine("FALTARAM: " + faltam.ToString("F2"));

            }
            else if (notaFinal >= 60 && notaFinal < 100)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");


            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("f2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("NOTA MAIOR QUE A PERMITIDA");
            }

        }
        #endregion

        #region Membros Estaticos
        public static void MembrosEstaticos()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = Convert.ToDouble(Console.ReadLine());
            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
        #endregion

        #region Construtores e Encapsulamento
        public static void Construtor()
        {
            // CALCULADORA //


            Console.Write("Nome do aluno ");
            string nome = Console.ReadLine();
            Console.Write("Valor do material:  ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Entities.Contrutores_e_Encapsulamento.Construtor cont = new Entities.Contrutores_e_Encapsulamento.Construtor(nome, preco, quantidade);
            Console.WriteLine(cont);







        }
        public static void Encapsulamento()
        {
            // BANCO DO BRASIL

            // DIGITAR O VALOR PARA SER DEPOSITADO NA CONTA
            // VER O SALDO 
            // RETIRAR O VALOR
            // VER O SALDO ATUALIZADO

            Entities.Contrutores_e_Encapsulamento.Encapsulamento encap = new Entities.Contrutores_e_Encapsulamento.Encapsulamento();

            Console.WriteLine("Digite o valor para deposito: ");
            encap.SetConta(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(encap);
            Console.WriteLine();
            Console.WriteLine("Retirar saldo: ");
            decimal ret = (Convert.ToDecimal(Console.ReadLine()));
            encap.RetirarValor(ret);
            Console.WriteLine(encap);




        }
        #endregion

        #region Exercicio Construtores e Encapsulamento

        /*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação. 
*/
        public static void ExercicioEncaEConst()
        {
            ContaBancaria conta;

            double deposito;
            double saque;

            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            ;
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string esc = Console.ReadLine();

            if (esc.ToUpper() == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
        #endregion

        #region Vetores

        public static void Vetores()
        {
            Pensionato[] vect = new Pensionato[10];
            Console.WriteLine("Quantos quartos serão alugados ? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nome;
                string email;
                int room;
                Console.WriteLine();
                Console.Write($"Rent #{i + 1}:");
                Console.WriteLine();
                Console.Write("Name: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = Convert.ToInt32(Console.ReadLine());
                vect[room] = new Pensionato(nome, email);
            }

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
        #endregion

        #region Laço foreach
        public static void Foraeach()
        {
        }
        #endregion

        #region Listas

        public static void Listas()
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(0, "Marcos");
            list.Add("Annnna");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' " + s2);
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' " + pos2);
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();

            List<string> listResultado = list.FindAll(x => x.Length == 5);

            foreach (string obj in listResultado)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("---");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Lista2()
        {
            List<Employee> ListFuncionatio = new List<Employee>();
            Console.WriteLine("How many employees will be registered ?");
            int contEmployee = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= contEmployee; i++)
            {
                Console.WriteLine("Emplyoee: #" + i);
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
                ListFuncionatio.Add(new Employee(id, nome, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            int idForFind = Convert.ToInt32(Console.ReadLine());
            Employee em = ListFuncionatio.Find(x => x.Id == idForFind);

            //Employee e a minha classe
            //em e o nome da minha variavel, ela vai receber o que encontrar FIND

            if (em != null)
            {
                Console.Write("Enter the percentage: ");
                decimal perct = Convert.ToDecimal(Console.ReadLine());
                em.AumentoPorcentagem(perct);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in ListFuncionatio)
            {
                Console.WriteLine(obj);
            }


        }

        #endregion

        #region Matriz
        public static void MatrizAprender()
        {
            // AULA 1
            /* double[,] mat = new double[2,3];
             Console.WriteLine(mat.Length);
             Console.WriteLine(mat.Rank);
             Console.WriteLine(mat.GetLength(0));
             Console.WriteLine(mat.GetLength(1));*/

            // AULA 2 
            int n;
            Console.Write("Digite N numero da matriz: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[n, n];
            Console.WriteLine(mat.Length);

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);

                }

            }

            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("Negative numbers: " + count);

        }

        #endregion

        #region Topicos Especiais
        public static void TopicosEspeciais()
        {
            //    double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    double desconto = (preco < 20.00) ? preco * 0.1 : preco * 0.05;
            //    Console.WriteLine(desconto);

            //    string original = "abcde FGHIJ ABC abc DEFG ";
            //    string s1 = original.ToUpper();
            //    string s2 = original.ToLower();
            //    string s3 = original.Trim();
            //    int n1 = original.IndexOf("bc");
            //    int n2 = original.LastIndexOf("bc");
            //    string s4 = original.Substring(3);
            //    string s5 = original.Substring(3, 5);
            //    bool b1 = String.IsNullOrEmpty(original);
            //    bool b2 = String.IsNullOrWhiteSpace(original);

            //    Console.WriteLine("Original: " + original);
            //    Console.WriteLine();
            //    Console.WriteLine("ToUpper: " + s1);
            //    Console.WriteLine("ToLower: " + s2);
            //    Console.WriteLine(s3);
            //    Console.WriteLine("IndexOf: ('bc'):  " + n1);
            //    Console.WriteLine("LastIndexOf: ('bc'):  " + n2);
            //    Console.WriteLine("Substring(3): " + s4);
            //    Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            //    Console.WriteLine("IsNullOrEmpty: " + b1);
            //    Console.WriteLine("IsNullOrWhiteSpace: "+b2);

            //    //TimeSpan
            //     TimeSpan tp = new TimeSpan();
            //     TimeSpan t1 = new TimeSpan(900000000L);
            //     TimeSpan t2 = new TimeSpan(2, 30, 21);
            //     TimeSpan t3 = TimeSpan.FromDays(1.5);

            //     Console.WriteLine(tp);
            //     Console.WriteLine(t1);
            //     Console.WriteLine(t2);
            //     Console.WriteLine(t3);

            //    // DataTime

            //    DateTime d = new DateTime(2022, 08, 16);
            //    DateTime d1 = d.AddHours(2);
            //    string s1 = d.ToString("yyy-MM-dd");
            //    DateTime d3 = DateTime.Now;
            //    DateTime vencimentoDeD3 = d3.AddDays(7);


            //    Console.WriteLine(d);
            //    Console.WriteLine(s1);
            //    Console.WriteLine(d1);
            //    Console.Write("Dia, mês e ano de agora| horario:  " + d3);
            //    Console.WriteLine();
            //    Console.WriteLine(vencimentoDeD3);

            // Propriedades e operações com TIMESPAN

            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            //Console.WriteLine(t);
            //Console.WriteLine("Days: " + t.Days);


        }
        #endregion
    }
}
