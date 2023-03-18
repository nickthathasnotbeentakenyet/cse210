class Video{

    // fields
    public string _title;
    public string _author;
    public int _length;
    public List<string> _comments = new List<string>();

    // methods
    public int GetCommentsNumber(){
        return _comments.Count();
    }

}