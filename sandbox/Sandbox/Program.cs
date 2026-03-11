using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your Last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {name} and your last name is {lastName}.");
    
    }
}