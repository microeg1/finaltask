using System;


class Program
{
    static void SortArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if(array1[i].Length <= 3)
            {
            array2[count] = array1[i];
            count++;
            }
        }
    }

    static void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        string[] array1 = new string[4] {"2", "hello", "world", ":-)"};
        string[] array2 = new string[array1.Length];
        SortArray(array1, array2);
        PrintArray(array2);
    }
}