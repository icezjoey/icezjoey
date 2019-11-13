using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer Wiskunde score in\n");
            Console.Write("Voor Scheikunde score in\n");
            Console.Write("Voor Natuurkunde score in\n");
            Console.Write("Is er een score lager dan 40 Ja/Nee\n");

            double Wiskunde = Convert.ToDouble(Console.ReadLine());
            double Scheikunde = Convert.ToDouble(Console.ReadLine());
            double Natuurkunde = Convert.ToDouble(Console.ReadLine());
            String AllSub = Convert.ToString(Console.ReadLine());

            if (Wiskunde > 60 && Scheikunde > 60 || Natuurkunde < 60
                || Wiskunde + Scheikunde + Natuurkunde == 180 || AllSub == "Nee") ;
            Console.Write("Je mag meedoen");

            if (AllSub == "Ja")
            Console.WriteLine("Je mag niet meedoen");

            else
                Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
//Wiskunde< 40 || Scheikunde< 40 || Natuurkunde< 40//