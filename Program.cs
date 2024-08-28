using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true; 

            do
            {
                Random randomNumberGenerator = new Random();
                int realnumber = randomNumberGenerator.Next(1, 101); //1 - (101 -1)

                Console.Write("Please guess a number between 0 and 100: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int amountguesses = 1;
                while (guess != realnumber)
                {
                    amountguesses++;
                    Console.Write("You guessed wrong, try guessing {0}; ", guess < realnumber ? "higher" : "lower");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine(Environment.NewLine + "You guessed right, it took you {0} attempts.", amountguesses);
                Console.Write(Environment.NewLine + "Do want to keep playing? (y/n): ");
                string playOption = Console.ReadLine();

                if (playOption.ToLower() == "n")
                keepPlaying = false;

            } while (keepPlaying);

      
            Console.WriteLine("Thank you for playing this game.");

            Console.ReadLine();
        }
    }
}
