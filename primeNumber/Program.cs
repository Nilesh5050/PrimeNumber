using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            int count=0;
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                if (num%i==0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num+" is a Prime Number");
            }
            else
            {
                Console.WriteLine(num+" is Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
