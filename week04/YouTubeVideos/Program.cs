using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial 1", "Cristofer Amachi", 600, new List<Comment>
        {
            new Comment("Mark", "Great tutorial!"),
            new Comment("Andrew", "Very helpful, thanks!"),
            new Comment("John", "I have a question about the code.")
        });
        Video video2 = new Video("C# Tutorial 2", "Cristofer Amachi", 800, new List<Comment>
        {
            new Comment("Luke", "I learned a lot from this video."),
            new Comment("Peter", "Can you make a video on advanced topics?"),
            new Comment("James", "This is a bit confusing, can you explain it again?")
        });
        Video video3 = new Video("C# Tutorial 3", "Cristofer Amachi", 1000, new List<Comment>
        {
            new Comment("Jeremiah", "Excellent content!"),
            new Comment("Paul", "Looking forward to more videos like this."),
            new Comment("Matthew", "I think there is a mistake in the code at 5:30.")
        });

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.Clear();

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}