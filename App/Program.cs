

using Models;
using System.Collections;

public class TraineeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        Trainee left = x as Trainee;
        Trainee right = y as Trainee;

        return left.Id.CompareTo(right.Id);
    }
}
public class Program
{
    public static void Main()
    {

        int[] arr = new
            int[] { 100, 2, 0, 14, 5, 60, -7, 8, };

        Trainee[] Ts = new Trainee[]
        {
            new Trainee(){Id=2, Name="Hany"}, 
            new Trainee(){Id=1, Name="Ahmed"}, 
        };

        Array.Sort(Ts, new TraineeComparer() );

        foreach(Trainee i in Ts)
            Console.WriteLine(i.ToString());
    }
}