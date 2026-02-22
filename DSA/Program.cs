using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.ExceptionServices;
using FactorialProject;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Choose A Problem to Run From the TUF List");
        Console.WriteLine($"Choice 1: Two Sum Problem");
        Console.WriteLine($"Choice 2: Max Profit Stock Problem");
        Console.WriteLine($"Choice 3: Contains Duplicate Problem");
        Console.WriteLine($"Choice 4: Reverse Words of a sentence not the characters of a sngle string");
        Console.WriteLine($"Choice 5: Enter Number for ref ");
        Console.WriteLine($"Choice 6: Enter Number for out ");
        Console.WriteLine($"Choice 7: Enter Number for factorial ");
        Console.WriteLine($"Choice 8: Enter length of array to sort ");
        Console.WriteLine($"Choice 9: Enter length of array to find missing number from an array ");
        Console.WriteLine($"Choice 10: Enter a string to reverse ...");
        Console.WriteLine($"Choice 11: Enter a string to find the distictness");
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
            case 5:
                int num = 5;
                refoutmethod(ref num);
                Console.WriteLine($"Number:{num}");
                break;
            case 6:
                int sum;
                outMethod(10, 20, out sum);
                Console.WriteLine($"Sum {sum}");
                break;
            case 7:
                FactorialOperation fact = new FactorialOperation();
                var num1 = 5;
                var fact1 = fact.Factorial(num1);
                Console.WriteLine(fact1);
                break;
            case 8:
                int a = Convert.ToInt32(Console.ReadLine());
                int[] b = new int[a];   // create array of size 'a'

                for (int i = 0; i < a; i++)
                {
                    b[i] = Convert.ToInt32(Console.ReadLine());
                }
                var result = BubbleSort(b);
                foreach(var item in result)
                {
                    Console.WriteLine(item);
                }
                break;
            case 9:
                int a1 = Convert.ToInt32(Console.ReadLine());
                int[] b1 = new int[a1];   // create array of size 'a'
                int n = 5;
                for (int i = 0; i < a1; i++)
                {
                    b1[i] = Convert.ToInt32(Console.ReadLine());
                }
                int misingNumber = MissingNumber(b1,n);
                Console.WriteLine($"Missing Number{misingNumber}");
                break;
            case 10:
                Console.WriteLine($"Enter string to reverse");
                string temp = Console.ReadLine();
                var reverse = ReverseAString(temp);
                Console.WriteLine($"Reverse ========>{reverse}");
                break;
            case 11:
                Console.WriteLine($"Enter string to find the disctinct characters");
                string distinctStr = Console.ReadLine();
                var disctinct = DistinctChar(distinctStr);
                foreach(var item in disctinct)
                {
                    Console.WriteLine($"Distinct characters are {item}");
                }
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }

    private static string ReverseAString(string word)
    {
        string temp = string.Empty;
        var len = word.Length;
        for(int i=len-1;i>=0; i--)
        {
            temp = temp + word[i];
        }
        return temp;
    }

    private static HashSet<char> DistinctChar(string word)
    {
        HashSet<char> distinct = new HashSet<char>();
        var len = word.Length;
        for(int i = 0; i < len; i++)
        {
            if (distinct.Contains(word[i]))
            {
                distinct.Remove(word[i]);
            }
            else
            {
                distinct.Add(word[i]);
            }
        }
        return distinct;
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

    //public static int Factorial(int num)
    //{
    //    int i = 1, f = 1;
    //    do
    //    {
    //        f = f * i;
    //        i++;
    //    }
    //    while (i <= num);
    //    return f;
    //}

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

    public static void refoutmethod(ref int temp)
    {
        temp = temp + 10;
    }

    public static void outMethod(int a,int b,out int sum)
    {
        sum = a + b;
    }

    public static int[] BubbleSort(int[] a)
    {
        int temp=0;
        for(int i = 0; i < a.Length-1; i++)
        {

            for(int j=0;j< a.Length-1-i; j++)
            {
                if (a[j] > a[j+1])
                {
                    temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;
                }
            }
        }
        return a;
    }

    //Selection sort
    public static int[] SelectionSort(int[] a)
    {
        var n = a.Length;
        for(int i = 0; i < n - 1; i++)
        {
            int min = i;
            for(int j = i+1; j < n; j++)
            {
                if (a[j] < min)
                {
                    min = j;
                }
            }
            int temp = a[i];
            a[i] = a[min];
            a[min] = temp;
        }
        return a;
    }

    //missing number from an array
    private static int MissingNumber(int[] array,int n)
    {
        int sum = array.Sum();
        //find missing number
        //1,3,4,5

        int sumOfN = n * (n + 1) / 2;
        int diff = sumOfN - sum;
        return diff;
    }
}
