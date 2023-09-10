namespace _11._09.Workers;

public class TeamLeader : IWorker
{
    public void Work() => Console.WriteLine(IWorker.report.ToString()); //Creates a work report and outputs it to the console
}
