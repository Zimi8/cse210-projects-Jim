using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 5);
        string text = "And by the power of the Holy Ghost ye may know the truth of all things.";
        Scripture scripture = new Scripture(reference, text);

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}