using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "yay") {
                Console.WriteLine("you did it!");
            }

            else
            {
                Console.WriteLine("invalid..");
            }
        }
    }
}
