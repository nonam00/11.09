namespace _11._09.House;
public class House
{
    public Basement Basement { get; set; } //1st stage
    public List<Wall> Walls { get; set; } //2nd stage
    public Roof Roof { get; set; } //3rd stage

    public List<Window> Windows {get; set;} // 4th stage
    public Door Door { get; set; } //5th stage
    
}
