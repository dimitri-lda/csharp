using System;

public class Lesson3
{
    public static void Main(string[] args)
    {
        Task41();
        Task43();
    }

    private static void Task41()
	{
		Console.WriteLine("Введите числа через запятую:");
		string input = Console.ReadLine();
		string[] nums = input.Split(',');

		int count = 0;
		foreach (string num in nums)
		{
			if (int.TryParse(num, out int n) && n > 0)
			{
				count++;
			}
		}

		Console.WriteLine("Количество чисел больше 0: {0}", count);
	}

    private static void Task43()
	{
        Console.WriteLine("Введите b1:");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите k1:");
        double k1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b2:");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите k2:");
        double k2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Значения x и y равны: ({0}; {1})", x, y);
    }
}