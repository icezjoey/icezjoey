using System;

namespace BMI2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type your weight:  ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Type your height:  ");
            int height = Int32.Parse(Console.ReadLine());

            double c = (height * height);

            double x = (weight / c);

            double z = (x * 10000);

            float i = (float)Math.Round(z, 1);

            Console.WriteLine("your bmi is: " + i);

            if (i < 10)
                Console.WriteLine("dude je bent waarschijnlijk gewoon dood");
            else
                if (i < 16)
                Console.WriteLine("severly underweight");
            else
                    if (i < 20)
                Console.WriteLine("bro als je beetje meer gaat eten is alles oke");
            else
                        if (i > 20)
                Console.WriteLine("GOEDZO a sahbi");
        }
    }
}
