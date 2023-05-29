using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create activities and add them to the list
        activities.Add(new Running("Running", "03 Nov 2022", 45, 5.5));
        activities.Add(new StationaryBicycles("Stationary Bicycles", "03 Nov 2022", 60, 25));
        activities.Add(new Swimming("Swimming", "03 Nov 2022", 40, 15));

        // Iterate through the list and display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}