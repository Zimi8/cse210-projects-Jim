using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "2")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start reflecting activity");
            Console.WriteLine("  2. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
        }
    }
}