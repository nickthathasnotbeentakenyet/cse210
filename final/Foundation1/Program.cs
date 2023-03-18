using System;

class Program
{
    static void Main(string[] args)
    {
        // allocate memory
        Video video_1 = new Video();
        Video video_2 = new Video();
        Video video_3 = new Video();

        Comment comment_1 = new Comment();
        Comment comment_2 = new Comment();
        Comment comment_3 = new Comment();
        Comment comment_4 = new Comment();
        Comment comment_5 = new Comment();
        Comment comment_6 = new Comment();
        Comment comment_7 = new Comment();
        Comment comment_8 = new Comment();
        Comment comment_9 = new Comment();
        
        List<Video> videos = new List<Video>();

        // set values 
        video_1._author = "Homer Simpson";
        video_2._author = "Bart Simpson";
        video_3._author = "Liza Simpson";

        video_1._title = "Sitting at Nuclear Station";
        video_2._title = "Wasting time at school";
        video_3._title = "Apply for city council";

        video_1._length = 28800;
        video_2._length = 3600;
        video_3._length = 60;

        
        comment_1._name = "Mr Burns";
        comment_1._comment = "I'm gonna fire this guy!";
        
        comment_2._name = "Ned Flanders";
        comment_2._comment = "This is my neighbor at work";
 
        comment_3._name = "Fat Tony";
        comment_3._comment = "This guy still ows me";

        comment_4._name = "Becky";
        comment_4._comment = "This boy looks handsome everywhere";

        comment_5._name = "Jenny";
        comment_5._comment = "Can't believe he lied to me";

        comment_6._name = "Gretta";
        comment_6._comment = "He is so brave";

        comment_7._name = "Ralph";
        comment_7._comment = "She could have been my wife one day";

        comment_8._name = "Lucas";
        comment_8._comment = "She eventually kissed me!";

        comment_9._name = "Luke";
        comment_9._comment = "Hate that girl!";

        video_1._comments.Add(comment_1.GetCombined());
        video_1._comments.Add(comment_2.GetCombined());
        video_1._comments.Add(comment_3.GetCombined());

        video_2._comments.Add(comment_4.GetCombined());
        video_2._comments.Add(comment_5.GetCombined());
        video_2._comments.Add(comment_6.GetCombined());

        video_3._comments.Add(comment_7.GetCombined());
        video_3._comments.Add(comment_8.GetCombined());
        video_3._comments.Add(comment_9.GetCombined());

        videos.Add(video_1);
        videos.Add(video_2);
        videos.Add(video_3);

        // display results
        foreach(Video video in videos){
            System.Console.WriteLine($"Title: \"{video._title}.\"");
            System.Console.WriteLine($"Author: {video._author}.");
            System.Console.WriteLine($"Length: {video._length}sec.");
            System.Console.WriteLine($"Comments: {video.GetCommentsNumber()}");
            foreach(string comment in video._comments){
                System.Console.WriteLine(comment);
            }
            System.Console.WriteLine("");
        }
    }
}