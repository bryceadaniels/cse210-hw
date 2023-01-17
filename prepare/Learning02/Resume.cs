public class Resume{
    public Resume(){}
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        System.Console.WriteLine($"Name: {_personName}");
        System.Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs){
            job.Display();
        }
    }
}