﻿using Tyuiu.PiskulinIY.Sprint0.Task4.V0.Lib;
namespace Tyuiu.PiskulinIY.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));

            //Вызов метода сложения Subtracktion
            Console.WriteLine(DataService.Subtraction(15, 5));

            //Вызов метода сложения Multiplication 
            Console.WriteLine(DataService.Multiplication(10, 10));

            //Вызов метода сложения Division
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
