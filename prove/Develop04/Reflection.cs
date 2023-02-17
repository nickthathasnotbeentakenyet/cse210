public class Reflection : Activity
{
    // members
    private int _thinkingPeriod;
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // constructors
    public Reflection(
        string activity, 
        string description, 
        int duration, 
        List<string> prompts, 
        List<string> questions, 
        int think) 
    : base(activity, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
        _thinkingPeriod = think;
    }

    // methods
    private string GetRandomPrompt(){
        Random random = new Random();
        int ind = random.Next(_prompts.Count);
        return (string)_prompts[ind];
    }

    private string GetRandomQuestion(){
        Random random = new Random();
        int ind = random.Next(_questions.Count);
        return (string)_questions[ind];
    }

    public void PrintReflection(){
        Colors c = new Colors();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n{c.cyan}--- {GetRandomPrompt()} ---{c.reset}");
        Console.WriteLine($"\nWhen you have something in mind, press {c.blue}enter{c.reset} to continue.");
        Console.ReadLine();
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        for(int i = 5; i>0; i--){
                Console.Write(c.red + i + c.reset);
                Thread.Sleep(1000);
                Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear();
        while(currentTime < endTime){
            Console.Write("\n> " + GetRandomQuestion() + " ");
            ShowAnimation(_thinkingPeriod);
            currentTime = DateTime.Now;
        }
        Console.WriteLine("\n");
        Console.WriteLine(WellDoneMsg());
    }
}