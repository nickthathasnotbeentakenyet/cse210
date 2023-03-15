class Video{

    public string _title;
    public string _author;
    public int _length; // in seconds
    public List<string> _comments = new List<string>();

    public int GetCommentsNumber(){
        return _comments.Count();
    }

}