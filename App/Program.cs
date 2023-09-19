

using Models;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 1, 2 };
        unsafe
        {
            fixed (int* ptr = arr)
            {
                for(int i =0; i< 2; i++)
                    Console.WriteLine( *(ptr+i) );
            }
        }
    }
}