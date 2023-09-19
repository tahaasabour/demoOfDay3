

using Models;

public class Program
{
    public static void Main()
    {
        Trainee[] arr = new Trainee[]
        {
            new Trainee{ Id=1, Name="Hany"}, 
            new Trainee{ Id=2,Name="Doaa"}
        };


        foreach(Trainee obj in arr)
        {
            Console.WriteLine(obj);
        }

        /*
        for(int i =0; i< arr.Length; i++)
        {
            Console.WriteLine(arr[i].ToString());
        }
        */


        //Console.WriteLine(arr[1].ToString());
    }
}