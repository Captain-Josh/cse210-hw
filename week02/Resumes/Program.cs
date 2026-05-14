using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle ="Software Developer";
        job1._company ="Google";
        job1._startYear = 2021;
        job1._endYear =2023;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle ="Success Consultant";
        job2._company ="eAssist";
        job2._startYear = 2026;
        job2._endYear =2040;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Nweke Joshua";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }

    
}