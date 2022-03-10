using System;
using static System.Math;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //Program calculate divide, addition, subtraction, multiplication two numbers           
            double a, b;
            Console.WriteLine("Prosty kalkulator który dzieli, dodaje, odejmuje i mnoży dwie liczby.");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Wyniki:");
            Console.WriteLine();
            Console.WriteLine("a/b = {0:#.##}", a / b);
            Console.WriteLine("a+b = {0:#.##}", a + b);
            Console.WriteLine("a-b = {0:#.##}", a - b);
            Console.WriteLine("a*b = {0:#.##}", a * b);
        }
    }
}
