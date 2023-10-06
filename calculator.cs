using System;

namespace Calculator
{
    internal class Program
    {
        public static int Result;
        public static void Add(int A, int B)
        {
            Result = A + B;
        }

        public static void Subtract(int A, int B)
        {
            Result = A - B;
        }

        public static void Multiply(int A, int B)
        {
            Result = A * B;
        }

        public static void Divide(int A, int B)
        {
            Result = A / B;
        }

        public static void Main(string[] args)
        {
            Add(10, 10);
            Console.WriteLine("Answer is: " + Result);

            Subtract(100, 70);
            Console.WriteLine("Answer is: " + Result);

            Multiply(3, 9);
            Console.WriteLine("Answer is: " + Result);

            Divide(50,5);
            Console.WriteLine("Answer is: " + Result);
            

        }
    }
}