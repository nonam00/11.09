namespace _11._09.Workers;
public interface IWorker
{
    static Report report { get; } = new();
    void Work();
}
