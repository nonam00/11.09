using System.Text;

namespace _11._09.Workers;

public class Report
{
    public static Dictionary<string, bool> work { get; set; } = new()
    {
        { "Basement", false },

        { "1st Wall", false },
        { "2nd Wall", false },
        { "3nd Wall", false },
        { "4nd Wall", false },

        { "Roof", false },

        { "1st Window", false },
        { "2nd Window", false },
        { "3nd Window", false },
        { "4nd Window", false },

        { "Door", false }
    };

    public override string ToString()
    {
        StringBuilder res = new();
        string status;
        foreach (var item in work)
        {
            status = item.Value ? "Done" : "Not Done";
            res.AppendLine($"{item.Key} - {status}");
        }
        return res.ToString();
    }
}