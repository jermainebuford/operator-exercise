using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine(a + b);
            Console.WriteLine(b - a);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("what is the radius of circle");

            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI* Math.Pow(radius, 2);

            Console.WriteLine($"the area of a circle with radius of {radius} is {area}" );



        }
    }
}
