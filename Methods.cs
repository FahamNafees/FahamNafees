using System;

namespace Methods
{
    internal class Program
    {
        private static int Result;

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

        public static void Pass(int A)
        {
            if (A > 30)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void AGrade(int A)
        {
            if (A >= 90)
            {
                Console.WriteLine("A+ Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void BGrade(int A)
        {
            if (A >= 70)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void CGrade(int A)
        {
            if (A >= 60)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void DGrade(int A)
        {
            if (A >= 50)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void Fail(int A)
            {
                if (A <= 49)
                {
                    Console.WriteLine("F Grade");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        public static void Main(string[] args)
        {
            Pass(97);
            AGrade(97);
            Pass(71);
            BGrade(71);
            Pass(66);
            CGrade(66);
            Pass(58);
            DGrade(58);
            Pass(34);
            Fail(34);
        }
    }
}