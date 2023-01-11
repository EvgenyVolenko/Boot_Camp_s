using static System.Console;
using static System.String;

public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 10) // min и max указаны как значения по умолчанию
    {
        return Enumerable.Range(1, size)
               .Select(item => Random.Shared.Next(min, max))
               .ToArray();
    }

    public static int[] Show(this int[] array, string separator = ", ")
    {
        string output = Join(separator, array);
        WriteLine($"Массив: [{output}]");
        return array;
    }
}