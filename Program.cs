class Program
{
    static void Main()
    {
        Fan1 sFan1 = new Fan1();
        sFan1.speed = 3;
        sFan1.radius = 10;
        sFan1.color = "Vang";
        sFan1.on = true;
        Console.WriteLine(sFan1.ToString());
        Fan2 sFan2 = new Fan2();
        sFan2.speed = 2;
        sFan2.radius = 5;
        sFan2.color = "Xanh";
        sFan2.on = false;
        Console.WriteLine(sFan2.ToString());
    }
}