using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            
            static int Fibonacci(int n)
            {
                if(n <= 1)
                    return n;
                else
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
