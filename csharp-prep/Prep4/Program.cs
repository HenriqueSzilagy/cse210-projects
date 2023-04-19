using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            int userNumbers = int.Parse(userNumber);
            number = userNumbers;
            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
            
        }
        int sum = 0;
        int largest = 0;
        foreach (int i in numbers)
        {  
            sum += i;
            if (i > largest)
            {
                largest = i;
            }
            
        }
        float average =(float) sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}