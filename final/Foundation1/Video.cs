public class Video {
    private string _title;
    private string _author;
    private int _length;
    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplaySummary(){
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine($"Title: '{_title}'");
        Console.WriteLine($"Author: '{_author}'");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments:");
        foreach (Comment comment in comments){
            string text = comment.GetComment();
            Console.WriteLine($"         {text}");
        }
    }   

    public void AddComment(Comment comment){
        comments.Add(comment);
    } 
}