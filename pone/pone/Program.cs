using System;
using pone.src;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter A and B to get C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            arithmetic add = new arithmetic();
            int c = add.addition(a, b);

            Console.WriteLine("The C vaule is : " + c);
        }
    }
}