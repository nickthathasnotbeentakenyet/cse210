class Comment{
    public string _name;
    public string _comment;

    public string getCombined(){
        return $"Comment by {_name}:\n\t\"{_comment}\"";
    }

}