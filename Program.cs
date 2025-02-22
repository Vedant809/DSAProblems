using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Choose A Problem to Run From the TUF List");
        Console.WriteLine($"Choice 1: Two Sum Problem");
        Console.WriteLine($"Choice 2: Max Profit Stock Problem");

        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Below");
        switch (choice)
        {
            case 1:
                TwoSum();
                break;
            case 2:
                MaxProfit();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }

    public static void MaxProfit()
    {
        int N = 6;
        int[] array = new int[N];
        for (int i = 0; i < 6; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int complement = 0;
        int max = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                complement = array[j] - array[i];
                if (complement > max)
                {
                    max = complement;
                }

            }
        }
        Console.WriteLine($"MAXIMUM PROFIT {max}");
    }

    public static void TwoSum()
    {
        int[] arr1 = new int[]
        {
            2,6,5,8,1
        };
        var target = 14;

        for (int i = 0; i < arr1.Length - 1; i++)
        {
            for (int j = i + 1; j < arr1.Length; j++)
            {
                int sum = arr1[i] + arr1[j];
                if (sum == target)
                {
                    Console.WriteLine($"Yes with indices {i} {j}");
                }

            }
        }
    }
}
