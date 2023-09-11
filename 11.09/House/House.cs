using System.Text;

namespace _11._09.House;
public class House
{
    public Basement Basement { get; set; } //1st stage
    public List<Wall> Walls { get; set; } //2nd stage
    public Roof Roof { get; set; } //3rd stage

    public List<Window> Windows {get; set;} // 4th stage
    public Door Door { get; set; } //5th stage

    public House()
    {
        Basement = null;
        Walls = new List<Wall>();
        Roof = null;
        Windows = new List<Window>();
        Door = null;
    }

    public string Status()
    {
        StringBuilder stringBuilder = new StringBuilder();
        
        if (Basement != null)
            stringBuilder.AppendLine("Basement - Done");

        if (Walls.Count == 4)
            stringBuilder.AppendLine("Walls - Done");

        if (Roof != null)
            stringBuilder.AppendLine("Roof - Done");

        if (Windows.Count == 4)
            stringBuilder.AppendLine("Windows - Done");

        if (Door != null)
            stringBuilder.AppendLine("Door - Done");

        if (Basement != null && Walls.Count == 4 && Roof != null && Windows.Count == 4 && Door != null)
            stringBuilder.AppendLine(
                "\nHouse is built\n\n" +
                "   __   \n" +
                "  /  \\  \n" +
                " / ## \\ \n" +
                "/  ##  \\\n" +
                "|      |  \n" +
                "|  ##  |  \n" +
                "|  ##  |  \n" +
                "--------\n"
                ) ;

        return stringBuilder.ToString();
    }

}
