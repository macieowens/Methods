using System;
using System.Security.Cryptography.X509Certificates;

namespace usethismethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Make a story with me!");
            
            Console.WriteLine($"What is your favorite song?");
            string favoriteSong = Console.ReadLine();
            Console.WriteLine($"That is a cool song!");

            Console.WriteLine($"My name is Macie. What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Cool name!");

            Console.WriteLine($"What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"Awesome!");

            Console.WriteLine($"One last question! What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"...Putting together your story...");

            Console.WriteLine($"This is my friend {name}." +
                $"We went to a {band} concert and they even got to hear them perform {favoriteSong}!" +
                $"Not to mention the lead singer was wearing a {color} shirt! {name}'s favorite color!");


            Console.WriteLine($"What is a number you'd like to add?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"What is a number you'd like to add to the first one?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The answer is: {sum}");

            Console.WriteLine($"What is a number you'd like to multiply?");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"What is a number you'd like to multiply to the first one?");
            num2 = int.Parse(Console.ReadLine());

            int answer = Multiply(num1, num2);
            Console.WriteLine($"The answer is: {answer}");
        }


        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++);
            {
                int i = 0;
                sum = sum + list[i];
            }

            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
