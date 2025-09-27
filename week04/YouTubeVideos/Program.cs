using System;

class Program
{
  static void Main(string[] args)
  {
    Video video1 = new Video("Advantures of a Lifetime", "John Doe", 120);
    Comment video1Comment1 = new Comment("Jane Doe", "That is the greatest advanture I've ever seen.");
    Comment video1Comment2 = new Comment("Mark Doe", "That's awesome.");
    Comment video1Comment3 = new Comment("Cookie Doe", "Masterpiece!");
    video1.SetComments(video1Comment1, video1Comment2, video1Comment3);


    Video video2 = new Video("The Return of They Who Had Left", "Rinnegan Max", 85);
    Comment video2Comment1 = new Comment("Six Paths Sage", "I always come back at the end.");
    Comment video2Comment2 = new Comment("Obito", "We could have never guessed.");
    Comment video2Comment3 = new Comment("UNDattebayo", "Masterpiece!");
    video2.SetComments(video2Comment1, video2Comment2, video2Comment3);

    Video video3 = new Video("Waters in Flame", "Sharingan Kakashi", 60);
    Comment video3Comment1 = new Comment("SasuFan", "Let it burn.");
    Comment video3Comment2 = new Comment("KaKaKaKa-shi", "That should have been a lost fight.");
    Comment video3Comment3 = new Comment("ChidoriSon", "I couldn't see that comming.");
    video3.SetComments(video3Comment1, video3Comment2, video3Comment3);

    video1.DisplayVideoDetails();
    video2.DisplayVideoDetails();
    video3.DisplayVideoDetails();
  }
}