using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video _video1 = new Video("Learn English", "Mary", 240);
        Video _video2 = new Video("Python Course", "Marcos", 1200);
        Video _video3 = new Video("Learn how to make a pizza", "Homer", 480);

        for(int i = 0; i < 3; i++){
            _video1.NewComment();
            _video2.NewComment();
            _video3.NewComment();
        }

        _videos.Add(_video1);
        _videos.Add(_video2);
        _videos.Add(_video3);

        foreach(Video video in _videos){
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}