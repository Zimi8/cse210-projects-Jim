using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string gradeLetter = "";
        string sign = "";

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int lastDigit = gradePercent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (gradeLetter == "A" && sign == "+")
        {
            sign = ""; 
        }
        else if (gradeLetter == "F")
        {
            sign = ""; 
        }
        Console.WriteLine($"Your final grade is: {gradeLetter}{sign}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep trying, you'll get it next time!");
        }
    }
}