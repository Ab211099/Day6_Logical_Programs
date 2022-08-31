using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci
    {
        public static void fibonoceiNumber()
        {
            Console.WriteLine("Please enter how many fibonacci numbers we have to generate");
            int number = Convert.ToInt32(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            int result = 0;
            result = firstNum + secondNum;
            Console.WriteLine("{0} {1} ", firstNum, secondNum);
            for (int i = 2; i < number; i++)
            {
                firstNum = secondNum;
                secondNum = result;
                result = firstNum + secondNum;
                Console.Write(" " + result);
            }
        }
    }
}
