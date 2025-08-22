public class Fan2 : Fan
{
    public bool On { get; set; } = false;

    public override string ToString()
    {
        string baseStatus = base.ToString();
        return baseStatus + $", Bat: {(On ? "Có" : "Không")}";
    }
}