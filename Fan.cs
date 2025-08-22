public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    public int speed { get; set; } = SLOW;
    public bool on{ get; set; } = false;
    public double radius{ get; set; } = 5;
    public string color{ get; set; } = "Xanh lam";
    public override string ToString()
    {
        if (on)
        {
            return $"[Fan is ON] Tốc độ: {speed}, Màu: {color}, Bán kính: {radius}";
        }
        else
        {
            return $"[Fan is OFF] Tốc độ: {speed}, Màu: {color}, Bán kính: {radius}";
        }
    }
}
