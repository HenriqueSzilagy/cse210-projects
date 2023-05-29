using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 Oak Avenue", "Coeur d'Alene", "Idaho", "USA");
        Address address2 = new Address("789 Yonge Street", "Toronto", "Ontario", "Canada");
        Address address3 = new Address("Benedito luiz rodrigues 459", "Sao Bernardo do Campo", "São Paulo", "Brazil");

        LectureEvent lecture = new LectureEvent("Lecture", "Henrique Falabela Meet and Greet", "An opportunity to meet and interact with renowned author Henrique Falabela", "2023-06-15", "18:00", address1, "Henrique Falabela", "100");
        ReceptionEvent reception = new ReceptionEvent("Reception", "VIP Reception", "An exclusive reception event reserved for VIPs and distinguished guests.", "2023-07-20", "20:00", address2, "rsvp.vipreception@gmail.com");
        OutdoorEvent outdoor = new OutdoorEvent("Outdoor", "Outdoor Music Festival", "A multi-day festival featuring live music performances in an open-air setting.", "2023-09-23", "16:00", address3, "22 °C Expect a delightful day with clear skies and abundant sunshine");
   
        Console.WriteLine("Lecture Event:");
        Console.WriteLine();
        Console.WriteLine(lecture.StandartDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine();
        Console.WriteLine(reception.StandartDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Event:");
        Console.WriteLine();
        Console.WriteLine(outdoor.StandartDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.ShortDescription());
    }
   
}
