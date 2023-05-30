using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {1, 2, 3, 4, 5};
        int[] array2 = {6, 7, 8, 9, 10};

        // Find minimum of array1
        int min1 = array1[0];
        for(int i = 1; i < array1.Length; i++)
        {
            if (array1[i] < min1)
            {
                min1 = array1[i];
            }
        }
        Console.WriteLine("Minimum of array1 is: " + min1);

        // Find maximum of array1
        int max1 = array1[0];
        for(int i = 1; i < array1.Length; i++)
        {
            if (array1[i] > max1)
            {
                max1 = array1[i];
            }
        }
        Console.WriteLine("Maximum of array1 is: " + max1);

        // Find minimum of array2
        int min2 = array2[0];
        for(int i = 1; i < array2.Length; i++)
        {
            if (array2[i] < min2)
            {
                min2 = array2[i];
            }
        }
        Console.WriteLine("Minimum of array2 is: " + min2);

        // Find maximum of array2
        int max2 = array2[0];
        for(int i = 1; i < array2.Length; i++)
        {
            if (array2[i] > max2)
            {
                max2 = array2[i];
            }
        }
        Console.WriteLine("Maximum of array2 is: " + max2);
    }
}
