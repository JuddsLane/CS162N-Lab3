using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loops are allowed for calling the methods right?
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(TriangleGrid(i));
            }

            static int TriangleGrid(int step)
            {
                if (step == 1)
                    return step;
                else
                    return step + TriangleGrid(step - 1);
            }
        }
    }
}
