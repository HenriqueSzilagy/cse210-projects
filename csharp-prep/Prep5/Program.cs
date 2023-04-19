using System;

class Program
{
    static void Main(string[] args)
    {
        static void main()
        {
            DisplayWelcome();
            string name = PromprUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromprUserName()
        {
            Console.Write("What is your Username? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int userNumber = int.Parse(number);
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        main();
    }
}