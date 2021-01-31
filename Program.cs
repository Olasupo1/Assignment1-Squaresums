using System;

namespace SquareSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string line;
            Console.WriteLine("Enter number: ");
            while ((line = System.Console.ReadLine()) != null)
            {
                int.TryParse(line, out n);
                if (n < 0)
                {
                    System.Console.WriteLine("Only numbers greater than zero is allowed");
                }
                else
                {
                    System.Console.WriteLine("Square sum: " + SquareSums(n));
                }
                
                Console.WriteLine("Enter number: ");
            }
        }

        private static bool SquareSums(int c)
        {
            for (long a = 0; a * a <= c; a++)
            {
                for (long b = 0; b * b <= c; b++)
                {
                    if (a * a + b * b == c)
                        return true;
                }
            }
            return false;
        }
    }
}
