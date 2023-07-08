using System;

public class Video{

    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    private Random _rand = new Random();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void NewComment(){
        Comment _comment = new Comment();

        List<string> _names = new List<string>{"Robert", "Peter", "Jesus", "Francisco", "Luis", "Jesus", "Jose", "Mark", "Karl", "Lauren", "Leonal", "Leandro", "Xavier", "Klaus", "Louis", "Dan", "Frank"};
        int _randomSelection = _rand.Next(0, _names.Count -1 ); 
        _comment.SetName( _names[_randomSelection]);
        List<String> _selectComment = new List<string>{"Excellent Video I really like it", "Good job, you're doing an excellent job!", "Continue Improving, you're going to be big", "I appreciate your work", "I wish you all the best", "I really enjoy watch your content", "Keep moving forward", "Keep climbing that hill, you'll get to the top", "I think you have to evaluate your content, I don't like this video", "This video has some stuff that is not appropiate", "You have to try to aim for different audience", "I don't like this video"};
        _randomSelection = _rand.Next(0, _selectComment.Count-1);
        _comment.SetComment(_selectComment[_randomSelection]);

        _comments.Add(_comment);
    }

    public int NumbComments(){
        return _comments.Count;
    }

    public void DisplayVideo(){
        Console.WriteLine($"The title of the video is {_title}. The author is {_author} with a length of {_length} seconds and have {NumbComments()} Comments: ");
        foreach(Comment comment in _comments){
            Console.WriteLine($"{comment.GetName()}: {comment.GetComment()}");
        }
    }

}