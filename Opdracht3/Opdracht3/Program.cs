using System;

namespace Taal_kiezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your Language: ");
            string language = Console.ReadLine();

            if (language == "Nederlands" || language == "nederlands")
                Console.WriteLine("De huidige maand is Maart.");

            if (language == "Duits" || language == "duits")
                Console.WriteLine("Der aktuelle Monat ist März.");

            if (language == "Engels" || language == "engels")
                Console.WriteLine("The current month is March.");

            if (language == "Frans" || language == "frans")
                Console.WriteLine("Le mois en cours est Mars.");

            if (language == "Spaans" || language == "spaans")
                Console.WriteLine("El mes actual es Marzo.");

            if (language == "Zweeds" || language == "zweeds")
                Console.WriteLine("Den nuvarande månaden är Mars.");

            Console.ReadKey();
        }
    }
}