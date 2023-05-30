using System;

class Program
{
    static void Main(string[] args)
    {
        // Student 1
        int[] grades1 = {85, 90, 78, 92, 88};
        double average1 = 0;
        for (int i = 0; i < grades1.Length; i++)
        {
            average1 += grades1[i];
        }
        average1 /= grades1.Length;
        string letterGrade1 = "";
        if (average1 >= 90)
        {
            letterGrade1 = "A";
        }
        else if (average1 >= 80)
        {
            letterGrade1 = "B";
        }
        else if (average1 >= 70)
        {
            letterGrade1 = "C";
        }
        else if (average1 >= 60)
        {
            letterGrade1 = "D";
        }
        else
        {
            letterGrade1 = "F";
        }
        Console.WriteLine("Student 1's final grade: " + letterGrade1);

        // Student 2
        int[] grades2 = {78, 76, 94, 86, 88};
        double average2 = 0;
        for (int i = 0; i < grades2.Length; i++)
        {
            average2 += grades2[i];
        }
        average2 /= grades2.Length;
        string letterGrade2 = "";
        if (average2 >= 90)
        {
            letterGrade2 = "A";
        }
        else if (average2 >= 80)
        {
            letterGrade2 = "B";
        }
        else if (average2 >= 70)
        {
            letterGrade2 = "C";
        }
        else if (average2 >= 60)
        {
            letterGrade2 = "D";
        }
        else
        {
            letterGrade2 = "F";
        }
        Console.WriteLine("Student 2's final grade: " + letterGrade2);
    }
}
