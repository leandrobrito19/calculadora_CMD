using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    internal class Program
    {

        enum Menu { soma = 1, subtracao = 2, divisao = 3, mutiplicacao = 4, potencia = 5, raiz = 6, sair = 7 }

        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("seja bem vindo ao CALC, selecione uma das opçoes:");
                Console.WriteLine("1-soma\n2-subtração\n3-divisão\n4-mutiplicação\n5-potencia\n6-raiz\n7-sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.soma:
                        Soma();
                        break;
                    case Menu.subtracao:
                        sub();
                        break;
                    case Menu.divisao:
                        Div();
                        break;
                    case Menu.mutiplicacao:
                        Muti();
                        break;
                    case Menu.potencia:
                        pot();
                        break;
                    case Menu.raiz:
                        raiz();
                        break;
                    case Menu.sair:
                        sair = true;
                        break;
                }

                Console.Clear();

            }


        }

        static void Soma()
        {
            Console.WriteLine("soma de dois numeros");
            Console.WriteLine("digite o primeito numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
        static void sub()
        {
            Console.WriteLine("subtração de dois numeros");
            Console.WriteLine("digite o primeito numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros");
            Console.WriteLine("digite o primeito numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
        static void Muti()
        {
            Console.WriteLine("Miltiplicação de dois numeros");
            Console.WriteLine("digite o primeito numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
        static void pot()
        {
            Console.WriteLine("potencia de um numero");
            Console.WriteLine("digite a base:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o expoente: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(a, b);
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
        static void raiz()
        {
            Console.WriteLine("raiz de um numero");
            Console.WriteLine("digite o numero:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"resultado: {resultado} ");
            Console.WriteLine("aperte ENTER para voltar pro menu");
            Console.ReadLine();
        }
    }
}