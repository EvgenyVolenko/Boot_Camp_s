using System.Diagnostics;

int size = 10_000_000;
int m = 30_000;

int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;

for (int j = 0; j < m; j++) max += array[j];
int t = max;

for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}

sw.Stop();

Console.WriteLine($"Time = {sw.ElapsedMilliseconds} мс");
Console.WriteLine($"Результат первого алогритма = {max}");

// Плохой вариант

sw.Start();

int max1 = 0;
int t1;

for (int i = 1; i < array.Length - m; i++)
{
    t1 = 0;
    for (int j = i; j < i + m; j++) t1 += array[j];
    if (t1 > max1) max1 = t1;
}

sw.Stop();

Console.WriteLine($"Time = {sw.ElapsedMilliseconds} мс");
Console.WriteLine($"Результат второго алогритма = {max1}");