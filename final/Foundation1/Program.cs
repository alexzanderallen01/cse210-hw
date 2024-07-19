using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        //video 1
        Video video1 = new Video("24 hours of random cat stuff", "Cat person", 1440);
        Comment video1Comment1 = new Comment("Cat123", "I love the cat at 1:23:45.");
        Comment video1Comment2 = new Comment("NeedMoreSleep", "Great video. 10/10 would sleep to again");
        Comment video1Comment3 = new Comment("Willium", "Great video. I would love to see another!");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);
        videosList.Add(video1);


        //video 2
        Video video2 = new Video("Micro Robotic Engineering", "The Big Engineer", 4440);
        Comment video2Comment1 = new Comment("Roburt", "Wow you're tall, but are working on robots smaller then we can see. Good job.");
        Comment video2Comment2 = new Comment("NeedMoreSleep", "WOW, the robots are so small in this video I fell asleep looking for them. Cool video tho.");
        Comment video2Comment3 = new Comment("Storm", "I wonder what would happen to those robots in a storm.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);
        videosList.Add(video2);

        //video 3
        Video video3 = new Video("Best way to cook BBQ for more then 5 people", "BBQ Man", 60);
        Comment video3Comment1 = new Comment("NeedMoreSleep", "I have never been more happy to take a nap after I cooked and eat all this food.");
        Comment video3Comment2 = new Comment("Willium the second", "Dad cooked this and it was great!");
        Comment video3Comment3 = new Comment("Cat123", "Alot of this food was ok for cats to eat. My cats are quite happy now.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}