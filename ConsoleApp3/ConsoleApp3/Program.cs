using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            AllNumbers();
            Console.WriteLine();
            AllNumbers1();
            Console.WriteLine();
            EqualOrNot(2, 3);
            Console.WriteLine();
            EvenOrOdd(0);
            Console.WriteLine();
            PositiveOrNegative(0);
            Console.WriteLine();
            VotingAge(1);

        }

        public static void AllNumbers()
        {
            int x = 1000;

            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(x);
                x--;
            }            
        }


        public static void AllNumbers1()
        {
            int x = 3;

            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(x);
                x += 3;
            }
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static bool EqualOrNot(int x, int y)
        {
            bool isTrue = true;

            if(x == y)
            {
                Console.WriteLine("Yes they are equal");
               
            }
            else
            {
                Console.WriteLine($"No {x} and {y} are not equal");
                isTrue = false;
            }

            return isTrue;
        }

        public static void EvenOrOdd(int x)
        {
            if(x % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
        }

        public static void PositiveOrNegative(int x)
        {
            if(x < 0)
            {
                Console.WriteLine("This is a negative number");
            }
            else
            {
                Console.WriteLine("This is a positive number");
            }
        }

        public static void VotingAge(int x)
        {
            if(x > 18)
            {
                Console.WriteLine("You are older than 18 and you can vote!");
            }
            else
            {
                Console.WriteLine("You are not older than 18 and you can't vote!");
            }
        }
        
    }
}
