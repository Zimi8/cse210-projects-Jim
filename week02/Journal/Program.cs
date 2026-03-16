using System;
// EXCEEDING REQUIREMENTS:
// 1 I wanted a greeting and exit messages to make more personal, inviting to think or ponder before writing or ponder.
// 2.Saved other information in the journal entry:The user is now prompted to enter their 'Mood' for the day as a personal register.
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGen promptGen = new PromptGen();
        string choice = "";

        Console.WriteLine("I know there something important that has happen to you today! So, want you want to do?");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("How was your mood today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }
        }

        Console.WriteLine("See you tomorrow!");
    }
}