using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("123 Main St", "Cityville", "NY", "12345");
        Address address2 = new Address("456 Oak St", "Townburg", "CA", "67890");
        Address address3 = new Address("789 Pine St", "Villagetown", "SF", "54321");

        Lecture lecture = new Lecture("Tech Summit", "Exploring the latest in technology", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), address1, "Adelfa C.L.", 150);
        Reception reception = new Reception("Grand Reception", "An elegant reception for everyone", DateTime.Now.AddDays(14), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy a day outdoors with friends", DateTime.Now.AddDays(21), new TimeSpan(12, 0, 0), address3, "Sunny with a high of 25°C");

        // Display Marketing Messages
        Console.WriteLine();
        Console.WriteLine("Lecture Marketing Messages:");
        Console.WriteLine("\n-- Standard Details --");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine("Reception Marketing Messages:");
        Console.WriteLine("\n-- Standard Details --");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine("Outdoor Gathering Marketing Messages:");
        Console.WriteLine("\n-- Standard Details --");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}