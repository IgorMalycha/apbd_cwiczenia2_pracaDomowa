﻿
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
    }

    public static int Average(int[] arr)
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i];
        }

        return res;
    }
    
    public static int Max(int[] arr)
    {
        int res = 0;

        for (int j = 0; j < arr.Length; j++)
        {
            if (res < arr[j])
            {
                res = arr[j];
            }
        }

        
        return res;
    }
}

