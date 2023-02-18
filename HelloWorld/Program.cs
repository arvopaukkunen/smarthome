using System;
//this must be in remote git when deploying to Ubuntu
// remote main branch is empty?
//dev1 branch created
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Please Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}