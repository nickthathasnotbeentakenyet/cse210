public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string txtBookSection, string problems) : base(name, topic)
    {
        _textBookSection = txtBookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"Section {_textBookSection} Problems {_problems}";
    }
}