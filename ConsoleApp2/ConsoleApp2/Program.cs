using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            var name=Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Surname");
            var surname=Console.ReadLine().ToUpper();
            Console.WriteLine(name +" "+ surname);
            Console.WriteLine("enter first letter");
            var first = Console.ReadLine();
            Console.WriteLine("enter second letter");
            var second = Console.ReadLine();
            Console.WriteLine("enter third letter");
            var third = Console.ReadLine();
            Console.WriteLine(third + second + first);
        }
    }
}
