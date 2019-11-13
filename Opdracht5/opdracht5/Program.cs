using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i < 2501; i++)
            {
                if (i % 4 != 0 || i == 1900 || i ==2100 || i == 1700 || i == 1500 || i == 2300 || i == 2500)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i + " is een schrikkeljaar");
                }
            }
            Console.ReadKey();
        }
    }
}
