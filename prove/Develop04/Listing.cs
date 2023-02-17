public class Listing : Activity
{
    // members
    private int _items = 0;
    private List<string> _prompts = new List<string>();

    // constructors
    public Listing(
        string activity, 
        string description, 
        int duration, 
        List<string> prompts) 
    : base(activity, description, duration)
    {
        _prompts = prompts;
    }
    
    // methods 
    private string GetRandomPrompt(){
        Random random = new Random();
        int ind = random.Next(_prompts.Count);
        return (string)_prompts[ind];
    }

    public void PrintListing(){
        Colors c = new Colors();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n{c.cyan}--- {GetRandomPrompt()} ---{c.reset}");
        Console.Write("\nYou may begin in: ");
        for(int i = 5; i>0; i--){
                Console.Write(c.red + i + c.reset);
                Thread.Sleep(1000);
                Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();
        while(currentTime < endTime){
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            _items++;
        }
        Console.WriteLine($"\nYou listed {c.cyan}{_items}{c.reset} items!\n");
        Console.WriteLine(WellDoneMsg());
    }
}