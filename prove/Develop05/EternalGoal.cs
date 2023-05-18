public class EternalGoal : Goal
{
    public EternalGoal(string goalType, string goalName, string description, int points) : base(goalType, goalName, description, points)
    {

    }
    public EternalGoal()
    {
        
    }
    public override void SetupGoalOnList()
    {
        SetGoalType("EternalGoal");
        string type = GetGoalType();
        GoalName();
        string name = GetName();
        GoalDescription();
        string description = GetDescription();
        GoalPoints();
        int points = GetPoints();
        
        EternalGoal eternalGoal = new EternalGoal(type, name, description, points);
        goals.Add(eternalGoal);
    }

    public override void RecordEvent(int index)
    {
        Goal goal = goals[index];
        int points = goal.GetPoints();
        _totalPoints += points ;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine("");
        Console.WriteLine($"You now have {_totalPoints} points");
    }
}