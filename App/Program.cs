

using Models;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 10, 20 };
        int[] arr2 = new int[arr.Length];


       // Array.Resize(ref arr2, arr2.Length + 1);

        arr2[2] = 90;

        foreach (int j in arr2)
            Console.WriteLine(j);


        //Array.Copy(arr, arr2, arr.Length);


        //int[] arr3 = new int[arr2.Length + 1];
        //Array.Copy(arr2, arr3, arr2.Length);


        // arr2 = arr3;

        //arr2[2] = 50;

        //foreach (int j in arr2)
        //    Console.WriteLine(j);

        /*
        for(int i =0; i < arr.Length; i++)
            arr2[i] = arr[i];
          */
        /*
        foreach(int j in arr)
            Console.WriteLine(j);
        */

        Console.WriteLine();


    }
}