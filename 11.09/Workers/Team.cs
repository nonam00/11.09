namespace _11._09.Workers;

public class Team : IWorker
{
    static int work_id = 0; //work stage
    private House.House house { get; set; }
    private List<Worker> workers = new List<Worker>();

    public Team(House.House house)
    {
        this.house = house;
        for (int i = 0; i < 11; i++)
            workers.Add(new Worker(i, house)); //distribution of construction stages among workers
    }
    public void Work()
    {
        workers[work_id++].Work();
    }
}
