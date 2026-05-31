using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();
        Video video1 = new Video("Introduction to C#", "Nweke Joshua", 500);
        video1.AddComment(new Comment("David","Detailed explanation."));
        video1.AddComment(new Comment("Mike","I learned a lot."));
        video1.AddComment(new Comment("Mum","Nice Video!"));

        Video video2 = new Video ("Avengers", "Stan Lee", 7200);
        video2.AddComment(new Comment("James", "Nice movie!"));
        video2.AddComment(new Comment("John", "It was worth the hype."));
        video2.AddComment(new Comment("Peter", "The director did a great job."));

        Video video3 = new Video ("Family Guy", "Seth MacFarlane", 7200);
        video3.AddComment(new Comment("Mike", "An interesting show"));
        video3.AddComment(new Comment("Blue", "Interesting!"));
        video3.AddComment(new Comment("Olusegun", "The show teaches a lot about society."));

        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}