using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Start  Number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter End Number: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Perfect Numbers From {start} To {end} Is: ");
            int sum;
            for (; start <= end; start++)
            {
                if (start == 0)
                {
                    continue;
                }
                sum = 0;
                for (int i = 1; i <= start; i++)
                {
                    if (start % i == 0)
                    {
                        sum += i;
                    }
                }
                if (start == sum / 2)
                {
                    Console.WriteLine(start);
                }
            }
        }
    }
}
