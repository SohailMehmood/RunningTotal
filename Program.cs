using System;

namespace RunningTotal;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        int sum = 0;
        var numbers = new List<int>()
            { 1, 2, 3, 4, 5};

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
}
