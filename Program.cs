﻿namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical program");
            Console.WriteLine("Enter the program number \n 1.Generate Fibonacci number");
            int optioncheck = Convert.ToInt32(Console.ReadLine());

            switch (optioncheck)
            {
                case 1:
                    Fibonacci.fibonoceiNumber();
                    break;
            }
        }
    }
}