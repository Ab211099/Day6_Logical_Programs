namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical program");
            Console.WriteLine("Enter the program number \n 1.Generate Fibonacci number \n 2. Perfect Number");
            int optioncheck = Convert.ToInt32(Console.ReadLine());

            switch (optioncheck)
            {
                case 1:
                    Fibonacci.fibonoceiNumber();
                    break;                
                case 2:
                    Perfect_Number.Perfectnumber();
                    break;
            }
        }
    }
}