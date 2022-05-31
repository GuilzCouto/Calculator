using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Qual operação matemática gostaria de fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                case 0 : Sair(); break;
                default: Menu(); break;
            }
        }

        static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos valores é: {x+y}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"A subtração dos valores é: {x-y}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"A divisão dos valores é: {x/y}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine($"A multiplicação dos valores é: {x*y}");
            Console.ReadKey();
            Menu();
        }

        static void Sair(){
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar a calculadora! Encerrando...");
            System.Environment.Exit(0);
        }
    }
}
