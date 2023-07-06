using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Pastor's FIRST TIME Inside Latter-day Saint Temple", "Hello Saints", 2040);
        Comment comment1 = new Comment("Flat Earth Math", "It is SO refreshing to hear someone outside of our religion be so respectful of our beliefs. Thank you, you are a beautiful soul.");
        Comment comment2 = new Comment("MagicJonesMusic", "I love this so much. Seeing two people who have differing beliefs engage in civil, friendly, uplifting conversation almost brings tears to my eyes. ");
        Comment comment3 = new Comment("bplaninz","I am a former LDS member, now an atheist, and I have to comment on how respectful and accurate your video is. Though I’m no longer practicing, I appreciate how you looked to understand rather than project ideas.");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("The Parable of the Slope", "The Church of Jesus Christ of Latter-day Saints", 326);
        Comment comment4 = new Comment("benjamintingey8516", "Beautiful message and artistry. Loved this line: 'He will do everything He can to help us turn our slopes toward heaven.'");
        Comment comment5 = new Comment("jcustard", "I really love this.  Please share talent like this more often.  It amplifies Gospel messages in such a striking way!");
        Comment comment6 = new Comment("scottsoward", "Christ can lift us from wherever we are... What an important message, and so beautifully illustrated.");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);

        Video video3 = new Video("Are You Really There?", "The Church of Jesus Christ of Latter-Day Saints", 225);
        Comment comment7 = new Comment("plaidspolitics", "We sang this at my son's funeral.  I can't hear it and not think of that day.  In my mind, I sometimes sing it as 'Heavenly Father, are you really there? Do you hear and answer every mother's prayer?");
        Comment comment8 = new Comment("brotherweterldr5085", "Thank you for showing the easily overlooked and silent everyday struggles that Heavenly Father sees. Surely, He is eager to bless those who would simply look to Him and pray. He is there.");
        Comment comment9 = new Comment("DeepSeaFisher5", "Even when things are at their darkest, there is always hope.  Pray, because He really is there and He really does care.");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        videos.Add(video3);

        foreach (Video video in videos){
            video.DisplaySummary();
        }

    }
}