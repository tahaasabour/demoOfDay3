

using Models;

public class Program
{
    public static void Main()
    {
        Trainee[] sdf = new Trainee[]
        {
            new Trainee { Id =1, Name="Ahmed"},
            new Trainee { Id =2, Name="Hany"}
        };
        Trainee[] dotNet = new Trainee[]
        {
            new Trainee { Id =1, Name="Doaa"},
            new Trainee { Id =2, Name="Saja"},
            new Trainee { Id =3, Name="Gamal"}
        };
        Trainee[][] Tracks = new Trainee[2][] { dotNet, sdf};


        foreach (Trainee[] row in Tracks)
        {
            foreach(Trainee t in row)
                Console.WriteLine(t);

            Console.WriteLine();
            Console.WriteLine();
        }

        /*
        for(int i =0; i < Tracks.Length; i++)
        {
            for(int j =0; j < Tracks[i].Length; j++)
                Console.WriteLine(Tracks[i][j].ToString());

            Console.WriteLine();
            Console.WriteLine();
        }
        */




        Console.WriteLine();
    }
}