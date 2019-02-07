using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isFirstEqualToSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 25, 5, 2, 3, 2, 2, 2, 4, 6, 7, 8, 12 };
            var count1 = 0;
            var count2 = 0;
            if (numbers.Length % 2 == 1)
            {
                Console.WriteLine("This is not an even array.");
            }

            else if (numbers.Length % 2 == 0)
            {
                var half = (numbers.Length / 2);
                for (int i = 0; i < half; i++)
                {
                    count1 += numbers[i];
                }
                for (int i = numbers.Length-1; i >= half; i--)
                {
                    count2 += numbers[i];
                }
                if (count1 == count2)
                {
                    Console.WriteLine("The first half is equal to {0} and the second half is equal to {1}, your array is equal on each half.", count1, count2);
                }
                else
                {
                    Console.WriteLine("The first half is equal to {0} and the second half is equal to {1}, your array is NOT equal on each half.", count1, count2);
                  
                }
            }
            Console.ReadLine();
        }
    }
}
