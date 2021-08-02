using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We Outside!");

            // Question1 //
            List<int> ans = Q1();
            Console.WriteLine("Capacity: {0}", ans.Capacity);

            // Question2 //
            Console.WriteLine("Factorial of 5 is: {0}", Q2(5));

            // Question4 //
            Console.Write(": ");
            string nums = Console.ReadLine();
            foreach (string i in Q4(nums))
            {
                Console.WriteLine(Q4(i));
            }
        }

        // Question1 //
        static List<int> Q1()
        {
            List<int> names = new List<int>();
            int i;

            for (i=2000; i<3200; i++)
            {
                if (i%7==0);
                {
                    if (i%5 != 0)
                    {
                        names.Add(i);
                    }
                }
            }

            return names;
        }

        // Question2 //
        static int Q2(int a)
        {
            if (a == 0 || a == 1)
            {
                return 1;
            }
            return a * Q2(a - 1);
        }

        // Question4 //
        static string[] Q4(string nums)
        {
            string[] num = nums.Split(", ");
            return num;
        }
    }
}
