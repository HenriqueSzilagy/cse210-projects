using System;

//core requirements

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage ?");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter = "";
        string sign = "";
        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80 )
        {
            letter = "B";
        }
        else if (gradeNumber >= 70 )
        {
            letter = "C";
        }
        else if (gradeNumber >= 60 )
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        //Strech requirements
        
        if ((gradeNumber % 10) >=7)
        {
            sign = "+";
        }
        else if ((gradeNumber % 10) < 3)
        {
            sign = "-";
        }
        Console.WriteLine($"Your Grade is {letter}{sign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations you passed on this course.");
        }
        else
        {
            Console.WriteLine("I'm sorry, but you did not achieve the minimum grade required to pass this course.Don't be discouraged. Use this experience to learn and improve. I believe in you!");
        }
    }
}   








