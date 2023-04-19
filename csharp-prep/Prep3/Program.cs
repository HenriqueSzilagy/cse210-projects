using System;

class Program
{
    static void Main(string[] args)
    {
        
        string response = "yes";
        while (response != "no")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guessNumber = 0;
            int track = 0;
            do
            {

                    Console.WriteLine("What is your guess?");
                    string guess = Console.ReadLine();
                    int guessConverted = int.Parse(guess);
                    guessNumber = guessConverted;
                    
                    track += 1;

                    if (guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
            } while (guessNumber != magicNumber);
            Console.WriteLine($"Congratulations you guessed in the {track} attempt!");
            Console.WriteLine("Do you want to play again? (Yes) or (No)");
            string yesOrNo = Console.ReadLine();
            string YesOrNoLower = yesOrNo.ToLower();
            response = YesOrNoLower;
        }
    }
}