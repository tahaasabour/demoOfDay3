

using Models;

public class Program
{
    public static void Main()
    {
        double[] arr = new [] { (double)1, 2, 3.9, 4, 5, new Trainee() };
        Console.WriteLine(arr.GetType());
    }
}