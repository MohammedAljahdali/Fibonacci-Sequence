using System;

namespace FibonacciSequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the nth number you want.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibSeq(n));
        }

        public static int fibSeq(int n)
        {
            if (n > 2)
                return fibSeq(n - 1) + fibSeq(n - 2);
            else return 1;
        }
    }
}
