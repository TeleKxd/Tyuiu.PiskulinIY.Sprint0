﻿namespace Tyuiu.PiskulinIY.Sprint0.Task5.V0;
    using Tyuiu.PiskulinIY.Sprint0.Task5.V0.Lib;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры 
            
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));

            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));

            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            Console.WriteLine("A / B = " + DataService.Division(9, 3));

        Console.ReadKey();
        }
    
    }

