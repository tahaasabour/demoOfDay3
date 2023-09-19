

using Models;

public class Program
{
    public static void Main()
    {
        Trainee[] Points = new Trainee[]
        {
            new Trainee() {Id=1, Name ="Hany"},
            new Trainee() {Id=2, Name ="Ahmed"},
        };
        Trainee[] Expensives = new Trainee[]
        {
            new Trainee() {Id=3, Name ="Doaa"},
            new Trainee() {Id=4, Name ="Sally"},
        };

       

        Trainee[,] Teams = new Trainee[2, 2] 
        {
            {
                new Trainee() {Id=1, Name ="Hany"},
                new Trainee() {Id=2, Name ="Ahmed"},
            },
            {
             new Trainee() {Id=3, Name ="Doaa"},
            new Trainee() {Id=4, Name ="Sally"},
            }
        };


        Console.WriteLine(Teams[1, 0]);
        Console.WriteLine();
        Console.WriteLine();
        foreach(Trainee t in Teams)
            Console.WriteLine(t);


        for (int i = 0; i < Teams.GetLength(0); i++)
        {
            for (int j = 0; j < Teams.GetLength(1); j++)
                Console.WriteLine(Teams[i, j]);
        }


    }
}