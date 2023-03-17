using System;

class Program
{
    static void Main(string[] args)
    {
        Address address_1 = new Address("1st Ave, Boston");
        Lecture lecture = new Lecture("MacroEconomics in 2023", "Let's just close our eyes", 
        "May 11, 2023", "10:00", address_1, "W. Speaker", 500);

        Address address_2 = new Address("2nd Ave, Los-Angeles");
        Reception reception = new Reception("ChatGPT", "A big problem or a big opportunity?",
        "April 11, 2023", "16:00", address_2, "chatgptLAconf@gmail.com");

        Address address_3 = new Address("Central Park, New-York");
        Outdoor  outdoor = new Outdoor("Aliens among us", "let's not cut people in halves to explore if that's true",
        "June 16, 2023", "13:00", address_3, "Sunny");

        System.Console.WriteLine(lecture.getStandardMsg());
        System.Console.WriteLine(lecture.getFullMsg());
        System.Console.WriteLine(lecture.getShortMsg());

        System.Console.WriteLine(reception.getStandardMsg());
        System.Console.WriteLine(reception.getFullMsg());
        System.Console.WriteLine(reception.getShortMsg());

        System.Console.WriteLine(outdoor.getStandardMsg());
        System.Console.WriteLine(outdoor.getFullMsg());
        System.Console.WriteLine(outdoor.getShortMsg());

    }
}