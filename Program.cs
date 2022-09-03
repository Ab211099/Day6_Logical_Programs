namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical program");
            Console.WriteLine("Enter the program number \n 1.Generate Fibonacci number \n 2. Perfect Number \n 3.Prime Number \n 4.Reverse number \n 5.Coupon number \n 6.Stimulate stop watch");
            int optioncheck = Convert.ToInt32(Console.ReadLine());

            switch (optioncheck)
            {
                case 1:
                    Fibonacci.fibonoceiNumber();
                    break;                
                case 2:
                    Perfect_Number.Perfectnumber();
                    break; 
                case 3:
                    Prime_number.FindPrime();
                    break; 
                case 4:
                    Reverse_number.FindReverseNumber();
                    break;
                case 5:
                  Coupon_Numbers.GetCouponNumber();
                    break;
                case 6:
                  Stop_watch.stopWatch();
                    break;
            }
        }
    }
}