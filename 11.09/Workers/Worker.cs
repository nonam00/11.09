namespace _11._09.Workers;
public class Worker : IWorker
{
    public int Id { get; set; }
    private House.House house { set; get; }
    public Worker(int id, House.House house)
    {
        Id = id;
        this.house = house;
    }

    public void Work()
    {
        if (Id == 0)
            house.Basement = new();
        else if (Id > 0 && Id < 5)
            house.Walls.Add(new House.Wall());
        else if (Id == 5)
            house.Roof = new();
        else if(Id>5 && Id<10)
            house.Windows.Add(new House.Window());
        else if (Id==10)
            house.Door = new();

    }
}
