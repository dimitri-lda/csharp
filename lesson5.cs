using System;

public class Lesson3
{
    public static void Main(string[] args)
    {
        Task34();
        Task36();
        Task38();
    }
    
    private static void Task34()
    {
        Random rand = new Random();
        int[] array = new int[]
        {
            rand.Next(999),
            rand.Next(999),
            rand.Next(999),
            rand.Next(999),
            rand.Next(999)
        };

        PrintArray(array);
        Console.WriteLine("Колличество четных чисел: {0}", FindEvenCount(array));
    }

    private static int FindEvenCount(int[] array)
    {
        int countEven = 0;
        foreach (int i in array)
        {
            if (i % 2 == 0)
                countEven++;
        }

        return countEven;
    }

    private static void Task36()
    {
        Random rand = new Random();
        int[] array = new int[]
        {
            rand.Next(199) - 100,
            rand.Next(199) - 100,
            rand.Next(199) - 100,
            rand.Next(199) - 100
        };

        PrintArray(array);
        Console.WriteLine("Сумма элементов на нечетных позициях: {0}", FindSumOfOddPositionElements(array));
    }

    private static int FindSumOfOddPositionElements(int[] array)
    {
        int sumOddPos = 0;

        for (int i=0; i<array.Length; i++)
        {
            if (i % 2 != 0)
                sumOddPos += array[i];
        }
        return sumOddPos;
    }

    private static void Task38()
    {
        Random rand = new Random();
        int[] array = new int[]
        {
            rand.Next(199) - 100,
            rand.Next(199) - 100,
            rand.Next(199) - 100,
            rand.Next(199) - 100,
            rand.Next(199) - 100
        };
        PrintArray(array);
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: {0}", GetMinMaxDiff(array));
    }

    private static int GetMinMaxDiff(int[] array)
    {
        return GetMax(array) - GetMin(array);
    }

    private static int GetMax(int[] array)
    {
        int max = array[0];
        foreach (int i in array)
        {
            if (i > max)
                max = i;
        }

        return max;
    }

    private static int GetMin(int[] array)
    {
        int min = array[0];
        foreach (int i in array)
        {
            if (i < min)
                min = i;
        }

        return min;
    }
    
    private static void PrintArray(int[] array)
    {
        Console.WriteLine("\r\n");
        Console.Write("Массив:");
        foreach (int i in array)
        {
            Console.Write(" {0}", i);
        }
        Console.Write("\r\n");
    }
}