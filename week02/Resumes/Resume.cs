public class Resume
{
  public string _name = "";
  public List<Job> _jobs = [];

  public void Display()
  {
    Console.WriteLine("Jobs:");
    for (int i = 0; i < _jobs.Count; i++)
    {
      _jobs[i].Display();
    }
  }
}