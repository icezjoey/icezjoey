using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type your name:  ");
            Console.WriteLine("");
            string name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Please Type the standard price:  ");
            Console.WriteLine("");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Do you want Metallic paint?:  ");
            Console.WriteLine("");
            string opt1 = Console.ReadLine();
            Console.WriteLine("");



            if (opt1 == "yes")
            {
                amount = amount * 1.05;
                Console.WriteLine("added paint");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No paint added");
                Console.WriteLine("");
                Console.WriteLine("");
            }
                

            Console.WriteLine("do you want a leather interior?:  ");
            Console.WriteLine("");
            string opt2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            if (opt2 == "yes")
            {
                amount = amount * 1.05;
                Console.WriteLine("Leather interior added");
                Console.WriteLine("");
            }  
            else
                Console.WriteLine("No interior added");
                Console.WriteLine("");


            Console.WriteLine("here is a printout of your specs");
            Console.WriteLine("");
            Console.WriteLine(name);
            Console.WriteLine("");
            if (opt2 == "yes")
            {
                Console.WriteLine("Paint" + "                " + "+" + amount * 0.05);
                Console.WriteLine("");
            }
 
            else
                Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("total amount" + "          " + amount);
            



            Console.ReadKey();
        }
    }
}

