public class Fan1 : Fan
{
    public bool On { get; set; } = false;

    public override string ToString()
    {
        string baseStatus = base.ToString();
        return baseStatus + $", Bat: {(on ? "Có" : "Không")}";
    }
}