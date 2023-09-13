namespace _11._09.Workers;
public class Worker : IWorker
{
    private static int global_id = 0;
    public int Id { get; set; }

    public bool Status { get; set; }
    private House.House house { set; get; }
    public Worker(House.House house)
    {
        Id = global_id++;
        this.house = house;
        Status = false;
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
        Status = true;
    }
}
