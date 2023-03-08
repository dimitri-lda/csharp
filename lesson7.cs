using System;

public class Lesson3
{
    public static void Main(string[] args)
    {
        Task47();
        Task50();
        Task52();
    }

    private static void Task47()
    {
        int col = 4;
        int raw = 3;
        double[][] array = Generate2DemArrayOfDoubles(col, raw);
        Print2DemArrayOfDoubles(array);
    }

    private static double[][] Generate2DemArrayOfDoubles(int col, int raw)
    {
        double[][] array = new double[raw][];
        Random rand = new Random();
        for (int rawIndex = 0; rawIndex < array.Length; rawIndex++)
        {
            array[rawIndex] = new double[col];
            for (int colIndex = 0; colIndex < array[rawIndex].Length; colIndex++)
            {
                array[rawIndex][colIndex] = rand.Next(-9, 9) + rand.NextDouble();
            }
        }
        return array;
    }

    private static void Print2DemArrayOfDoubles(double[][] array)
    {
        Console.WriteLine("Двумерный массив:");
        foreach (double[] i in array)
        {
            foreach (double j in i)
                Console.Write("{0:F1} ", j);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void Task50()
    {
        int col = 4;
        int raw = 3;
        int[][] array = Generate2DemArrayOfInts(col, raw);
        Print2DemArrayOfInts(array);

        Console.WriteLine("Введите номер столбца в массиве (от 1): ");
        int colEl = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("Введите номер строки в массиве (от 1): ");
        int rawEl = int.Parse(Console.ReadLine()) - 1;

        if (colEl >= 0 && colEl < col && rawEl >= 0 && rawEl < raw)
            Console.WriteLine("Число в массиве: {0}\n", array[rawEl][colEl]);
        else
            Console.WriteLine("Такого числа в массиве нет.\n");
    }

    private static void Task52()
    {
        int col = 4;
        int raw = 3;
        int[][] array = Generate2DemArrayOfInts(col, raw);
        Print2DemArrayOfInts(array);
        PrintColumnsAvg(FindColumnsAvg(array));
    }

    private static double[] FindColumnsAvg(int[][] array)
    {
        int numberOfColumns = array[0].Length;
        int numberOfRows = array.Length;
        double[] colAvg = new double[numberOfColumns];
        int colSum = 0;

        for (int colIndex = 0; colIndex < numberOfColumns; colIndex++)
        {
            foreach (int[] ints in array)
                colSum += ints[colIndex];
            colAvg[colIndex] = (double) colSum / numberOfRows;
            colSum = 0;
        }

        return colAvg;
    }

    private static void PrintColumnsAvg(double[] array)
    {
        Console.Write("Среднее арифметическое каждого столбца:\r\n");
        foreach (double i in array)
            Console.Write("{0:F1} ", i);
        Console.Write("\r\n");
    }

    private static int[][] Generate2DemArrayOfInts(int col, int raw)
    {
        int[][] array = new int[raw][];
        Random rand = new Random();
        for (int rawIndex = 0; rawIndex < array.Length; rawIndex++)
        {
            array[rawIndex] = new int[col];
            for (int colIndex = 0; colIndex < array[rawIndex].Length; colIndex++)
                array[rawIndex][colIndex] = rand.Next(0, 9);
        }
        return array;
    }

    private static void Print2DemArrayOfInts(int[][] array)
    {
        Console.WriteLine("Двумерный массив:");
        foreach (int[] i in array)
        {
            foreach (int j in i)
                Console.Write("{0} ", j);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}