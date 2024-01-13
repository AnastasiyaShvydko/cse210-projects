using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Learning02 World!");
       Job job = new Job();
       job._company = "MicroSoft";
       job._jobTitle = "Software Engineer";
       job._startYear =  2019;
       job._endYear =  2022;

       Job job1 = new Job();
       job1._company = "Apple";
       job1._jobTitle = "Manager";
       job1._startYear =  2022;
       job1._endYear =  2023;

       //job.DisplayJobDetails();
       //job1.DisplayJobDetails();

       Resume myResume = new Resume();
       myResume._jobs.Add(job);
       myResume._jobs.Add(job1);
       //Console.WriteLine(myResume._jobs[1]._jobTitle);
       myResume._name = "Allison Rose";
       myResume.Display();
    }
}


