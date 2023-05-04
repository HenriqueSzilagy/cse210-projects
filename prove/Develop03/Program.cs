using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("", 0, 0);
        reference.SetReference("João", 3, 5, 0);
        string scriptureString = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God";
        Scripture john3_5 = new Scripture(reference, scriptureString);
        string scriptureReference = reference.GetReference();
        
        string menuUserinput = "";
        string alltheSentence = "";

        Console.WriteLine($"{scriptureReference} {scriptureString}");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        menuUserinput = Console.ReadLine();

        while (menuUserinput != "quit")
        {
            if (john3_5.isCompletelyHidden() == true){
                break;
            }
            else{   
                Console.Clear();
                john3_5.HideRandomWords();
                alltheSentence = john3_5.GetRenderedText();
                Console.WriteLine($"{scriptureReference} {alltheSentence}");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                menuUserinput = Console.ReadLine();
            }
            
        }
        Console.WriteLine("Thank you");
    }
    
}