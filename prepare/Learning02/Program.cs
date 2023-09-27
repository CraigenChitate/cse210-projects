using System;

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        // Job job1 = new Job();
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        // Job job2 = new Job();
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job2._startYear = 2022;
        // job2._endYear = 2023;



    
        // Create a resume and add the job instances
        Resume myResume = new Resume("Allison Rose");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume details using the Display method
        myResume.Display();
    }
}
