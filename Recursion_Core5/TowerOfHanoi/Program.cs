using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 3;//int.Parse(Console.ReadLine());

            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();

            A.Push(10);
            B.Push(10);
            C.Push(10);

            for(int i = n; i > 0; i--)
                    A.Push(i);

            Hanoi(n, A, B, C, false);

            static void Hanoi(int n, Stack<int> A, Stack<int> B, Stack<int>C, bool altMove)
            {   
                int exit = 0;
                
                    exit++;
                    if (exit > 100) {
                        Console.WriteLine("STACK OVERFLOW");
                        return;
                    }

                    Stack<int> top = new Stack<int>();
                    Stack<int> med = new Stack<int>();
                    Stack<int> low = new Stack<int>();

                    int a = A.Peek();
                    int b = B.Peek();
                    int c = C.Peek();

                    if (a == 1)
                        top = A;
                    else if (b == 1)
                        top = B;
                    else if (c == 1)
                        top = C;

                    if (a > b && a < c || a > c && a < b)
                        med = A;
                    if (b > a && b < c || b > c && b < a)
                        med = B;
                    if (c > a && c < b || c > b && c < a)
                        med = C;
                    
                    if (a > b && a > c)
                        low = A;
                    if (b > a && b > c)
                        low = B;
                    if (c > a && c > b)
                        low = C;



                    if (altMove == false)
                    {
                        if (A == top)
                            C.Push(A.Pop());
                        if (B == top)
                            A.Push(B.Pop());
                        if (C == top)
                            B.Push(C.Pop());
                        altMove = true;
                    }
                    else
                    {
                        low.Push(med.Pop());
                        altMove = false;
                    }

                    foreach (var item in A)
                        Console.WriteLine(item);
                    Console.WriteLine();
                    foreach (var item in B)
                        Console.WriteLine(item);
                    Console.WriteLine();
                    foreach (var item in C)
                        Console.WriteLine(item);
                    Console.WriteLine("break");

                    if (C.Count > n) 
                    {
                        Console.WriteLine("finished");
                        return;
                    }
                    else
                        Hanoi(n, A, B, C, altMove);
                
            }
        }
    }
}
