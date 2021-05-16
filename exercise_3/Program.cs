using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(new double[,] { { 1, 2, 3 }, { 4, 6, 7 }, { 8, 9, 10 } });
            Matrix b = new Matrix(new double[,] { { 32, 31, 31 }, { 21, 21, 21 }, { 21, 21, 21 } });

            (a + b).ToString();
            (a - b).ToString();
            (-a).ToString();
            (a * b).ToString();

            if (a == b)
            {
                Console.WriteLine("a is the same as b");
            }
            if (a != b)
            {
                Console.WriteLine("a is not the same as b");
            }

            Console.WriteLine(a.Determinant().ToString());
        }
    }
}
