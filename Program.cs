﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void  Menu()
        {
             Console.Clear();

             Console.WriteLine("O que deseja fazer?");
             Console.WriteLine("1 - Soma");
             Console.WriteLine("2 - Subtração");
             Console.WriteLine("3 - Divisão");
             Console.WriteLine("4 - Multiplicação");
             Console.WriteLine("5 - Sair");

             Console.WriteLine("-----------------");
             Console.WriteLine("Selecione uma opção:");

            short id = short.Parse(Console.ReadLine());

             switch(id)
             {
                 case 1: Soma(); break;
                 case 2: Subtracao(); break;
                 case 3: Divisao(); break;
                 case 4: Multiplicacao(); break;
                 case 5: System.Environment.Exit(0); break;
                 default: 
                    Console.WriteLine("Você selecionou a alternativa incorreta.");
                    Console.ReadKey();
                    Menu();
                    break;
             }

             Console.ReadKey();
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            while(v2 == 0)
            {
                Console.WriteLine("O Dividendo não pode ser zero");
                Console.WriteLine("Segundo valor: ");
                v2 = float.Parse(Console.ReadLine());
            }

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão é: {resultado}");

            Console.ReadKey();
            Menu();


        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }

    }
}
