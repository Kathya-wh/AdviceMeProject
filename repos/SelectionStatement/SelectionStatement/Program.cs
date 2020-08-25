using System;
using System.ComponentModel;
using System.Threading;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our number guessing game!");
            Console.WriteLine("Try to correctly guess the random number");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());


            if (guess > number)
            {
                Console.WriteLine("Your guess is too high, Try again!");
            }
             else if (guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }
             else
            {
                Console.WriteLine("Correct!");
            }





        }
    }
}
