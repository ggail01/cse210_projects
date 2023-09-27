using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Quality Control";
        job1._company = "Shalom Fashion House";
        job1._startYear = 1994;
        job1._endYear = 2002;
        // job1.DisplayJob();

        Job job2 = new Job();
        job2._jobTitle = "Sub-con Quality Inspector";
        job2._company = "Engleco Phil.";
        job2._startYear = 2002;
        job2._endYear = 2005;
        // job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Marife Bado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}