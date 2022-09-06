using System.Net.WebSockets;
using System.Reflection.PortableExecutable;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Even numbers between 1 and 10
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Reverse the for loop
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Iterate through a name with a for loop
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Iterate through a name using foreach loop
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            // Iterate over an array
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            // While Loop - Use when unsure of number of iterations
            while (true)
            {
                Console.Write("Type your name:\n>>>>");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("@Echo: " + input);
                    break;
                }

            }
            

        }
    }
}