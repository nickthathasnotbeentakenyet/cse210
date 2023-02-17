public class Activity{
    
    // members
    private int _defaultDuration;
    protected string _activityName;
    protected string _description;
    protected int _duration;
    
    // Access to colors
    Colors c = new Colors();

    // constructors 
    public Activity(string activity, string description, int duration){
        _activityName = activity;
        _description = description;
        _duration = duration;
    }
    // getters & setters
    public int setDuration {set => _duration = value;}

    // methods
    public void GetStartingMsg(){
        string decor = new string('=',34);
        Console.WriteLine(c.cyan + decor + c.reset);
        Console.WriteLine($"Welcome to the {c.cyan}{_activityName}{c.reset}");
        Console.WriteLine(c.cyan + decor + c.reset);
        Console.WriteLine("\n" + _description);
    }
    public string GetEndingMsg(){
        return $"You have completed another {c.cyan}{_duration}{c.reset} seconds of the {c.cyan}{_activityName}{c.cyan}.";
    }
    public string WellDoneMsg(){
        return $"{c.green}{c.bold}Well done!!{c.reset}";
    }
    public int GetDuration(){
        Console.WriteLine($"\nHow long, {c.cyan}in seconds{c.reset}, would you like for your session?");
        Console.Write($"{c.blue}:> {c.reset}");
        string userDuration = Console.ReadLine();
        // In case user enters wrong value -> default value is returned
        if (int.TryParse(userDuration, out _defaultDuration)){
            return int.Parse(userDuration);
            }
        else{
            _defaultDuration = 30;
            Console.WriteLine($"{c.red}Error. {c.cyan}{userDuration}{c.red} is not integer. Default {c.cyan}{_defaultDuration}{c.red} is set.{c.reset}");
            Console.Write($"{c.blue}Press any key to continue.{c.reset}");
            Console.ReadKey();
            return _defaultDuration;}
    }

    public void ShowAnimation(int period){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(period);
        DateTime currentTime = DateTime.Now;
        while(currentTime < endTime){
            List<string> chars = new List<string>() {"\\","|","/","─"};
            foreach(string sign in chars){
                Console.Write(c.yellow + sign + c.reset);
                Thread.Sleep(150);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }
    }
}