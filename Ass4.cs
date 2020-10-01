using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Ass4
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int even = 0, odd = 0;

            // Loop to find even, odd sum 
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    even += arr[i];
                else
                    odd += arr[i];
            }

            Console.WriteLine("Even sum " + even);

            Console.WriteLine("Odd sum " + odd);
        }
    }
}