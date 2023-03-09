using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Task54();
        Task56();
        Task58();
        Task60();
        Task62();
    }

    private static void Task54()
    {
        int col = 4;
        int raw = 3;
        int?[][] array = generate2DemArrayOfInts(col, raw);
        print2DemArrayOfInts(array);
        int?[][] sortedArray = sort2DemArrayRows(array);
        print2DemArrayOfInts(sortedArray);
    }

    private static int?[][] generate2DemArrayOfInts(int col, int raw)
    {
        int?[][] array = new int?[raw][];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int?[col];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = rand.Next(9);
            }
        }
        return array;
    }

    private static void print2DemArrayOfInts(int?[][] array)
    {
        Console.WriteLine("Двумерный массив:");
        foreach (int?[] i in array)
        {
            foreach (int? j in i)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static int?[][] sort2DemArrayRows(int?[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length - 1; j++)
            {
                for (int k = j + 1; k < array[i].Length; k++)
                {
                    if (array[i][j].GetValueOrDefault() < array[i][k].GetValueOrDefault())
                    {
                        int? temp = array[i][j];
                        array[i][j] = array[i][k];
                        array[i][k] = temp;
                    }
                }
            }
        }
        return array;
    }

    private static void Task56() {
        int col = 4;
        int raw = 4;
        int[][] array = Generate2DemArrayOfInts2(col, raw);
        Print2DemArrayOfInts2(array);
        int minSumRowIndex = FindRawWithMinElemSum(array);
        Console.WriteLine("Индекс строки с минимальной суммой элементов: " + minSumRowIndex);
        PrintArray(array[minSumRowIndex]);
        Console.WriteLine();
    }

    private static int FindRawWithMinElemSum(int[][] array) {
        int sum = array[0].Sum();
        int resultIndex = 0;
        for (int i = 0; i < array.Length; i++) {
            int currentSum = array[i].Sum();
            if (currentSum < sum) {
                sum = currentSum;
                resultIndex = i;
            }
        }
        return resultIndex;
    }

    private static int[][] Generate2DemArrayOfInts2(int col, int raw) {
        int[][] array = new int[raw][];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++) {
            array[i] = new int[col];
            for (int j = 0; j < array[i].Length; j++) {
                array[i][j] = rand.Next(9);
            }
        }
        return array;
    }

    private static void Print2DemArrayOfInts2(int[][] array) {
        Console.Write("Двумерный массив:\r\n");
        foreach (int[] i in array) {
            foreach (int j in i) {
                Console.Write($"{j} ");
            }
            Console.Write("\r\n");
        }
        Console.Write("\r\n");
    }

    private static void PrintArray(int[] array) {
        foreach (int i in array) {
            Console.Write($"{i} ");
        }
        Console.Write("\r\n");
    }

    public static void Task58()
    {
        int[][] matrix1 = generateMatrix();
        Console.WriteLine("Матрица 1:");
        printMatrix(matrix1);

        int[][] matrix2 = generateMatrix();
        Console.WriteLine("Матрица 2:");
        printMatrix(matrix2);

        Console.WriteLine("Произведение матриц 1 и 2:");
        printMatrix(getMatrixMultiplication(matrix1, matrix2));
        Console.WriteLine();
    }

    private static int[][] generateMatrix()
    {
        Random rand = new Random();
        return new int[][] { new int[] { rand.Next(9), rand.Next(9) }, new int[] { rand.Next(9), rand.Next(9) } };
    }

    private static int[][] getMatrixMultiplication(int[][] matrix1, int[][] matrix2)
    {
        int[][] resultMatrix = new int[matrix1.Length][];
        for (int i = 0; i < resultMatrix.Length; i++)
        {
            resultMatrix[i] = new int[matrix2[0].Length];
        }

        for (int i = 0; i < matrix1.Length; i++)
        {
            for (int j = 0; j < matrix2[0].Length; j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1[0].Length; k++)
                {
                    sum += matrix1[i][k] * matrix2[k][j];
                }
                resultMatrix[i][j] = sum;
            }
        }

        return resultMatrix;
    }

    private static void printMatrix(int[][] matrix)
    {
        foreach (int[] rows in matrix)
        {
            foreach (int elem in rows)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
    }

    private static void Task60()
    {
        int[][][] array = generate3DemArrayOfInts(2);
        print3DemArrayOfInts(array);
        Console.WriteLine();
    }

    private static int[][][] generate3DemArrayOfInts(int arraySize)
    {
        Random rand = new Random();
        int[][][] array = new int[arraySize][][];
        List<int> tempArrayList = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[arraySize][];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = new int[arraySize];
                for (int k = 0; k < array[i][j].Length; k++)
                {
                    int number = rand.Next(99);
                    while (tempArrayList.Contains(number))
                    {
                        number = rand.Next(99);
                    }
                    array[i][j][k] = number;
                    tempArrayList.Add(number);
                }
            }
        }

        return array;
    }

    private static void print3DemArrayOfInts(int[][][] arr)
    {
        Console.WriteLine("Трехмерный массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                for (int k = 0; k < arr[i][j].Length; k++)
                {
                    Console.Write(arr[i][j][k] + "(" + i + "." + j + "." + k + ") ");
                }
                Console.WriteLine();
            }
        }
    }


    public static void Task62()
    {
        int[,] array = FillHelixArray(4);
        Console.WriteLine("Массив заполненый в виде спирали");
        Print2DemArrayOfInts3(array);
    }

    public static int[,] FillHelixArray(int arraySize)
    {
        int[,] array = new int[arraySize, arraySize];
        int number = 1;
        int row = 0;
        int column = 0;

        while (number <= arraySize * arraySize)
        {
            for (int i = column; i < arraySize - column; i++)
            {
                array[row, i] = number;
                number++;
            }
            for (int i = row + 1; i < arraySize - row; i++)
            {
                array[i, arraySize - column - 1] = number;
                number++;
            }
            for (int i = arraySize - column - 2; i >= column; i--)
            {
                array[arraySize - row - 1, i] = number;
                number++;
            }
            for (int i = arraySize - row - 2; i > row; i--)
            {
                array[i, column] = number;
                number++;
            }
            row++;
            column++;
        }

        return array;
    }

    public static void Print2DemArrayOfInts3(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}
