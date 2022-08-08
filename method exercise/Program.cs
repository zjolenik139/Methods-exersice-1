using System;

namespace method_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine("What is your favorite Animal");
            var animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"My name is {name},My favorite color is {color}, My favorite animal is {animal}, My favorite band is {band}");
        }   
    }
}
