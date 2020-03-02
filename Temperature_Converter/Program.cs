using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Farenheit to Ceilsus

            Console.WriteLine("Write temperature value in farenheit and i will tell you how much is this in ceilsus");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Formula F to C

            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("Entered value equals {0} Ceilsius", FtoC);
            Console.ReadLine();

            // Ceilsus to Farenheit

            Console.WriteLine("Write temperature value in ceilsus and i will tell you how much is this in farenheit");
            int cel = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Formula C to F

            int CtoF = ((cel * 9) / 5) + 32;
            Console.WriteLine("Entered value equals {0} Farenheit", CtoF);
            Console.ReadLine();


        }
    }
}
