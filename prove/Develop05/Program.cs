using System;

class Program
{
    static void Main(string[] args)
    {
         int menuUserinput = 0;
         int goalUserinput = 0;
        List<string> menu = new List<string>
        {
        "1. Create New Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };
        

        List<string> goalMenu = new List<String>
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };
        
        Goal goal = new Goal();
     while (menuUserinput != 6)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {goal.GetTotalPoints()} points.");
            Console.WriteLine("");
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
                    Console.WriteLine("The types of goals are:");
                    foreach (string goalMenuItem in goalMenu)
                        {
                            Console.WriteLine($"  {goalMenuItem}");
                        }
                        Console.WriteLine("Which type of goal would you like to create?");
                        try
                        {
                            goalUserinput = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                    if (goalUserinput == 1)
                        {
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.SetupGoalOnList();
                        }
                    else if (goalUserinput == 2)
                        {
                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.SetupGoalOnList();
                        }
                    else
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.SetupGoalOnList();
                        }
                        break;
                case 2:
                        
                        goal.ListGoals();
                        break;

                case 3:
                        goal.SaveGoals();
                        break;
                case 4:
                        
                        goal.LoadGoals();
                        break;
                case 5:
                        goal.DisplayRecordOption();
                        int index = goal.GetIndex();
                        goal.RecordEvent(index);
                        break;

                case 6:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}