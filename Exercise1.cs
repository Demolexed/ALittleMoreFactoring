using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {1, 2, 3, 4, 5};
        int sum1 = 0;
        for(int i = 0; i < array1.Length; i++)
        {
            sum1 += array1[i];
        }
        Console.WriteLine("Sum of array1 elements: " + sum1);

        int[] array2 = {6, 7, 8, 9, 10};
        int sum2 = 0;
        for(int i = 0; i < array2.Length; i++)
        {
            sum2 += array2[i];
        }
        Console.WriteLine("Sum of array2 elements: " + sum2);
    }
}