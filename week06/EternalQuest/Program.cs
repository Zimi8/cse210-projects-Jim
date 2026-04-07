using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exceeding Requirements: Added a Leveling Gamification feature.");
        Console.WriteLine("The GoalManager automatically assigns the user a 'Level' based on their total score (1 Level per 1000 points).");
        
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}