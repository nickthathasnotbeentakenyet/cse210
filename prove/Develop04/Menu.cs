public class Menu{

    // members
    private List<string> _menuItems = new List<string>();
    
    // constructors
    public Menu(List<string> menu) {
        _menuItems = menu;
    }

    // methods
    public void ShowMenu(){
        Colors c = new Colors();
        int count = 1;
        Console.WriteLine($"{c.blue}Menu Options:");
        foreach(string line in _menuItems){
            Console.WriteLine($"  {c.blue}{count}. {c.magenta}{line}{c.reset}");
            count++;
        }
    }
    public string GetUserMenu(){
        return Console.ReadLine();
    }

}