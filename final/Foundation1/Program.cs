using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Tutorial how to learn c#", "Elon Music", 120);
        video1.AddComment("Ralph Lorena", "Amazing video, with this knowledge i could improve my skills");
        video1.AddComment("Jorge Brooksfold", "Wow i loved your video and your accent, congrats");
        video1.AddComment("Enzo Ferraro", "Thank you for this video, now i build a program to my cars");
        video1.AddComment("Alexandre Gaulis", "im so happy for you teach me to program, thank youu");

        Video video2 = new Video("Travel to Tokyo, enjoy in this adventure with me !", "Bill Getter", 180);
        video2.AddComment("Masashi kishimura", "Is an incredible video! I felt like I was right there with you");
        video2.AddComment("Rafael Bonaparty", "Awesome video! making me feel like I was exploring the city alongside you");
        video2.AddComment("Daniel Apoka", "Thank you, Your video beautifully showcased the blend of tradition and modernity that Tokyo offers");

        Video video3 = new Video("How to connec your second monitor", "Jeff branches", 240);
        video3.AddComment("Jordan Halo", "Thank you soo much, you saved my life");
        video3.AddComment("Bill Jr", "Amazing video, simple and concise");
        video3.AddComment("Elon Jr", "Thank youu now i can work with two monitors !");


        
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._lenght + " seconds");
            Console.WriteLine("Number of Comments: " + video.NumComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("Comment by " + comment._commenter + ": " + comment._text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}