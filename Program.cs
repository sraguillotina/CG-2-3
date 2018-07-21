using System;

namespace Class2_StringCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, there. What's your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What's your favorite season of the year," + " " + name + "?");
            Console.Write("Season: ");
            string season = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What is your favorite activity during the " + season + "?");
            Console.Write("Activity: ");
            string activity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(name + " " + "likes" + " " + activity + " " + "during the" + " " + season + ".");
            Console.ReadLine();


        }
    }
}
