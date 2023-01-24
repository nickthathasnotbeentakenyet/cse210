public class Prompt{
    public List<string> _promptList = new List<string>();

    public string PromptGenerator(){
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
}