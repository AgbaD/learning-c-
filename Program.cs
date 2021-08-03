using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We Outside!");

            // Question 1 //
            List<int> ans = Q1();
            Console.WriteLine("Capacity: {0}", ans.Capacity);

            // Question 2 //
            Console.WriteLine("Factorial of 5 is: {0}", Q2(5));

            // Question 3 //
            Console.Write(": ");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, int> item in Q3(n))
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }


            // Question 4 //
            Console.Write(": ");
            string nums = Console.ReadLine();
            foreach (string i in Q4(nums))
            {
                Console.WriteLine(i);
            }
        }

        // Question 1 //
        static List<int> Q1()
        {
            List<int> nums = new List<int>();
            int i;

            for (i=2000; i<3200; i++)
            {
                if (i%7==0)
                {
                    if (i%5 != 0)
                    {
                        nums.Add(i);
                    }
                }
            }

            return nums;
        }

        // Question 2 //
        static int Q2(int a)
        {
            if (a == 0 || a == 1)
            {
                return 1;
            }
            return a * Q2(a - 1);
        }

        // Question 3 //
        static Dictionary<int, int> Q3(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int i;

            for (i=1; i <= n; i++)
            {
                dict.Add(i, i*i);
            }

            return dict;
        }

        // Question 4 //
        static string[] Q4(string nums)
        {
            string[] num = nums.Split(", ");
            return num;
        }
    }
}
