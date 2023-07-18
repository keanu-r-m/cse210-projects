public class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();
    public string DisplayVideoProperty() {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length}\nNumber of comments: {_commentList.Count}\n";
    }
}