using System;

namespace RunningTotal;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        var numbers = new List<int>()
            { 107, 92, 3, 46, 5096, 666, 85 };

        Console.WriteLine(numbers.Count);
    }
}
