using System;
using System.Collections.Generic;
using System.Diagnostics;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Choose A Problem to Run From the TUF List");
        Console.WriteLine($"Choice 1: Two Sum Problem");
        Console.WriteLine($"Choice 2: Max Profit Stock Problem");
        Console.WriteLine($"Choice 3: Contains Duplicate Problem");
        Console.WriteLine($"Choice 4: Reverse Words of a sentence not the characters of a sngle string");

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
            case 3:
                Duplicate();
                break;
            case 4:
                ReverseWord();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }

    private static void ReverseWord()
    {
        var str = "My Name is Vedant";
        string[] arrayString = new string[5];
        arrayString = str.Split(" ");
        string reverse = string.Empty;
        for(int i = arrayString.Length-1; i >= 0; i--)
        {
            reverse = reverse+ " " + arrayString[i];
        }
        Console.WriteLine($"Reversed words of a sentence =========>{reverse.ToString()}");
    }

    //Generic function to use everywhere
    private static int[] CommonArray()
    {
        Console.WriteLine("Ënter the Length of the Array");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < 6; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }

    public static void MaxProfit()
    {
        int N = 6;
        int[] array = new int[N];
        for (int i = 0; i < 6; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        //        **Brute Force**

        //int complement = 0;
        //int max = 0;
        //for (int i = 0; i < array.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < array.Length; j++)
        //    {
        //        complement = array[j] - array[i];
        //        if (complement > max)
        //        {
        //            max = complement;
        //        }

        //    }
        //}
        //Console.WriteLine($"MAXIMUM PROFIT {max}");


        //**Optimized Solution**

        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (var price in array)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, (price - minPrice));
            }
        }
        Console.WriteLine($"MAXIMUM PROFIT {maxProfit}");

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

    public static void Duplicate()
    {
        int[] nums = CommonArray();
        HashSet<int> hash = new HashSet<int>();

        foreach(var item in nums)
        {
            if (hash.Contains(item))
            {
                Console.WriteLine($"Array Contains Duplicate Item {item}");
                break;
            }
            else
            {
                hash.Add(item);
            }
        }
    }

}
