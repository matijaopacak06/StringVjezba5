using System;

namespace Primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene razmakom:");

            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int x = int.Parse(numbers[0]);
            double y = double.Parse(numbers[1]);

            Console.WriteLine("Uneseni brojevi su:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
}
