using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vidur Bhardwaj";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine("Please enter your name : ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hi {0} let's play a game", inputName);
            Console.WriteLine("Guess any number between 1 and 10 : ");
            while (true)
            {
                int guess = 0;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                while (guess != correctNumber)
                {
                    String input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Enter Integer only !");
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Number :(, Please try again");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Correct guess :) ....Victory!");
                Console.WriteLine("Please try playing again : ");
            }
        }
    }
}
