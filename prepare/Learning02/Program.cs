using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2014;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2024;

        // job1.DisplayJob();
        // job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Joseph Budu";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJob();


    }
}