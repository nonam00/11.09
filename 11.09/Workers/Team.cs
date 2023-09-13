namespace _11._09.Workers;

public class Team : IWorker
{
    static int work_id = 0; //work stage
    private List<Worker> workers = new List<Worker>();

    public Team(House.House house)
    {
        for (int i = 0; i < 11; i++)
            workers.Add(new Worker(house)); //distribution of construction stages among workers
    }
    public void Work()
    {
        if (work_id==0 || workers[work_id-1].Status)
            workers[work_id++].Work();
    }
}
