using _11._09.House;
namespace _11._09.Workers;

public class TeamLeader : IWorker
{
    private House.House house { get; set; }

    public TeamLeader(House.House house) => this.house = house;

    public void Work() //Creates a work report and outputs it to the console
    {
        if (house.Status() == String.Empty)
            Console.WriteLine("Construction of the house hasn't started yet\n");
        else
            Console.WriteLine(house.Status() + "\n"); 
    }
}
