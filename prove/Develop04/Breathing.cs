public class Breathing : Activity
{
    public Breathing(string activity, string description, int duration) : base(activity, description, duration)
    {
    }

    public void PrintActivity(){
        ShowAnimation(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            ShowCounter("in");
            Console.WriteLine();
            ShowCounter("out");
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
            }
        Console.WriteLine(WellDoneMsg());
        ShowAnimation(5);
    }
    static void ShowCounter(string inOut){
        Colors c = new Colors();
        string message;
        int i;
        if (inOut == "in"){
            message = $"{c.cyan}Breathe in...";
            i = 4;
        }
        else{
            message = $"{c.cyan}Now breathe out...";
            i = 6;
        }
        Console.Write(message);
        for(; i>0; i--){
                Console.Write(c.red + i + c.reset);
                Thread.Sleep(1000);
                Console.Write("\b \b");
        }
    }
    
}