using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        // Creating videos and adding comments
        Video video1 = new Video("Five Beautiful Ways To Decorate Cake", "Tasty", 540);
        video1.AddComment("Marife Bado", "These decorating ideas are so creative!");
        video1.AddComment("Adelfa Limpado", "The ombre effect is my favorite!");
        video1.AddComment("Abigail Bado", "The flower design is absolutely stunning!");

        Video video2 = new Video("Knitting for Beginners", "Hobby Lobby", 840);
        video2.AddComment("Letecia Coral", "Your knitting tutorials are a lifesaver for beginners like me.");
        video2.AddComment("Paula Jean P.", "Your explanations are clear, and the close-ups help a lot.");
        video2.AddComment("Tyzmaine A.", "I've always wanted to learn how to knit, and your video made it so much less intimidating.");
        video2.AddComment("Mylene M.", "The beginner-friendly projects are exactly what I needed.");

        Video video3 = new Video("Business Look Makeup Tutorial", "Alexa Chung", 480);
        video3.AddComment("Aiyana Daneiris", "Your makeup tutorials are my go-to for professional looks.");
        video3.AddComment("Cherry Mae A.", "The tips for a polished business look are so helpful.");
        video3.AddComment("Shiela Coral L.", "Love the emphasis on a natural look for the workplace.");

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}