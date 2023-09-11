using _11._09.House;
namespace _11._09.Workers;

public class TeamLeader : IWorker
{
    private House.House house { get; set; }

    public TeamLeader(House.House house) => this.house = house;

    public void Work() => Console.WriteLine(house.Status()); //Creates a work report and outputs it to the console
}
