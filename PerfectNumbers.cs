using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramingDay6
{
    internal class PerfectNumbers
    {
        public static void FindPerfectNumber()
        {
            int number, sum = 0, n;
            Console.Write("Enter the Number:-");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered Number is Perfect Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered Number is Not a Perfect Number");
                Console.ReadLine();
            }
        }
    }
}
