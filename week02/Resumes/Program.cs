using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "IT Customer Support";
        job1._company = "Atentus";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Python Developer";
        job2._company = "Tech Solutions";
        job2._startYear = 2026;
        job2._endYear = 2028;

        Resume myResume = new Resume();
        myResume._name = "Ezequiel Jimenez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}