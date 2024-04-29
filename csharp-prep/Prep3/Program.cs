using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        string game;
        int guess;
        
        do
        {
            int guessAmount = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            game = "yes";

            Console.WriteLine(number);
            do
            {
                Console.WriteLine("Guess a number from 1-100: ");
                string userguess = Console.ReadLine();
                guess = int.Parse(userguess);
                

                if (guess > number)
                {
                    guessAmount++;
                    Console.WriteLine("The number is lower");
                    Console.WriteLine($"You have guessed {guessAmount} times.");
                    
                }
                else if (guess < number)
                {
                    guessAmount++;
                    Console.WriteLine("The number is higher");
                    Console.WriteLine($"You have guessed {guessAmount} times.");
                    
                }
                else if (guess == number)
                {
                    guessAmount++;
                    Console.WriteLine("You got the number!");
                    Console.WriteLine($"You have guessed {guessAmount} times.");
                    game = "no";

                }

            } while (game == "yes");


            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");

    }
}