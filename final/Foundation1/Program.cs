using System;

class Program
{
    static void Main(string[] args)
    {
        Video vidOne = new Video();
        vidOne._author = "Elisabeth Fraser";
        vidOne._title = "How to have a beautiful voice";
        vidOne._length = 300;
        vidOne._commentList.Add(new Comment("Keanu", "I Thanks for the video, it was very helpful"));
        vidOne._commentList.Add(new Comment("Amethyst", "This is the best video I have ever watched!"));
        vidOne._commentList.Add(new Comment("Cyriel", "I want more videos like this!"));

        Video vidTwo = new Video();
        vidTwo._author = "Robin Guthrie";
        vidTwo._title = "How to use reverb on guitar";
        vidTwo._length = 600;
        vidTwo._commentList.Add(new Comment("Mika", "Reverb is my favorite guitar effect, thanks!"));
        vidTwo._commentList.Add(new Comment("Dreamer", "The explanarion is awesome!"));
        vidTwo._commentList.Add(new Comment("Sagitarius", "Very helpful video, thank you Robin"));

        Video vidThree = new Video();
        vidThree._author = "Simon Raymonde";
        vidThree._title = "How to play post-punk bass";
        vidThree._length = 900;
        vidThree._commentList.Add(new Comment("Goth004", "I will finally use my guitar bass thanks to you, great video!"));
        vidThree._commentList.Add(new Comment("Will Heggie", "As a professional bass player, I am impressed!"));
        vidThree._commentList.Add(new Comment("Robert Smith", "Do you want a collaboration with the cure?"));

        List<Video> videos = new List<Video>() {
            vidOne, vidTwo, vidThree
        };
        foreach (Video video in videos) {
            Console.WriteLine(video.DisplayVideoProperty());
        }
    }
}