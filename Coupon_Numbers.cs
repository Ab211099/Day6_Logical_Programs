using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
     class Coupon_Numbers
    {
        public static void GetCouponNumber()
        {
            Random random = new Random();
            int NUM = (random.Next(1, 6));

            int COUPON1 = 185620;
            int COUPON2 = 163467;
            int COUPON3 = 172390;
            int COUPON4 = 128690;
            int COUPON5 = 139870;

            if (NUM == 1)
            {
                Console.WriteLine("your coupon number is : " + COUPON1);
            }
            else if (NUM == 2)
            {
                Console.WriteLine("your coupon number is :" + COUPON2);
            }
            else if (NUM == 3)
            {
                Console.WriteLine("your coupon number is :" + COUPON3);
            }
            else if (NUM == 4)
            {
                Console.WriteLine("your coupon number is :" + COUPON4);
            }
            else if (NUM == 5)
            {
                Console.WriteLine("your coupon number is :" + COUPON5);
            }
        }
    }
}

