using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_number
    {
        public static void FindReverseNumber()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            for( int i =0; i < num; i++)
            {
                int reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num = num / 10;
                break;
            }
            Console.WriteLine(reverse);
        }
    }
}
