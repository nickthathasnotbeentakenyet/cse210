class Comment{
    
    // fields
    public string _name;
    public string _comment;
    
    // methods
    public string GetCombined(){
        return $"Comment by {_name}:\n\t\"{_comment}\"";
    }

}