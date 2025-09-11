using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();
    job1._jobTitle = "Full Stack Development";
    job1._company = "GE";
    job1._startYear = 2020;
    job1._endYear = 2023;

    job1.Display();

    Job job2 = new Job();
    job2._jobTitle = "Back End Developer";
    job2._company = "EDP";
    job2._startYear = 2023;
    job2._endYear = 2025;

    job2.Display();

    Resume resume1 = new Resume();
    resume1._name = "Rodolfo Recordon";
    resume1._jobs.Add(job1);
    resume1._jobs.Add(job2);

    resume1.Display();
  }
}