using System;

class Program
{
    static void Main(string[] args)
    {
         int menuUserinput = 0;

        List<string> menu = new List<string>
        {
        "1. Start breathing activity",
        "2. start reflecting activity",
        "3. start listing activity",
        "4. Quit",
    };

     while (menuUserinput != 4)
        {
            Console.WriteLine("Menu Options:");
            foreach (string menuItem in menu)
            {
                Console.WriteLine($"  {menuItem}");
            }
            Console.WriteLine("Select a choice from the menu:");
            try
            {
                menuUserinput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (menuUserinput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunBreathingActivity();
                    break;

                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.RunReflectionActivity();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunListingActivity();
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}