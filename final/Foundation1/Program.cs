using System;

namespace YouTube
{

  class Program
  {
    static void Main(string[] args)
    {
      /**
      * Create Videos
      */
      List<Video> Videos = new List<Video>();
      Video video1 = new Video("Crazy Stuff", "Aaron", 10);
      Video video2 = new Video("Not Crazy", "Madi", 200);
      Video video3 = new Video("Crazy Stuff", "Aaron", 10);
      Video video4 = new Video("Crazy Stuff", "Aaron", 10);

      /**
      * Create Comment Lists
      */
      List<Comment> comments1 = new List<Comment>{
      new Comment("SuperStar01", "This video was amazing!"),
    new Comment("PowerGirl", "This video was was trash!"),
    new Comment("Gamer123", "This video was so cool!")};

      List<Comment> comments2 = new List<Comment>{
      new Comment("MovieLover", "I loved this video!"),
    new Comment("MusicFan", "The music in this video was awesome!"),
    new Comment("Bookworm", "I learned a lot from this video!")};

      List<Comment> comments3 = new List<Comment>{
      new Comment("FitnessFreak", "This video was great for my workout routine!"),
    new Comment("ComedyFan", "I laughed so hard watching this video!"),
    new Comment("Foodie", "The recipe in this video was amazing!")};


      List<Comment> comments4 = new List<Comment>{
       new Comment("TechNerd", "This video helped me fix my computer problem!"),
    new Comment("DIYer", "I got inspired to do a DIY project from this video!"),
    new Comment("Traveler", "This video made me want to go on a trip!")};

      /**
      * Add Comment Lists
      */
      video1.addComments(comments1);
      video2.addComments(comments2);
      video3.addComments(comments3);
      video4.addComments(comments4);


      /**
      * Add to Video 
      */
      Videos.AddRange(new[] { video1, video2, video3, video4 });

      /**
      * Display
      */
      Display(Videos);
    }

    public static void Display(List<Video> videos)
    {

      videos.ForEach(video =>
      {
        //Go through the video's main information
        Console.WriteLine("***********************************");
        Console.WriteLine($"The video's title is \"{video.Title}.\"");
        Console.WriteLine($"The video's author is {video.Author}.");
        Console.WriteLine($"The video is {video.Length} seconds long.");
        Console.WriteLine($"The video has {video.Comments.Count} comment(s)");
        Console.WriteLine();
        video.Comments.ForEach(comment =>
        {
          Console.WriteLine($"  {comment.Name} says:");
          Console.WriteLine($"  {comment.Text}");
          Console.WriteLine();
        });
        Console.WriteLine();

      });
    }
  }
}