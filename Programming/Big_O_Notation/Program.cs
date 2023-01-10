Console.Clear();
Console.WriteLine("Введите размер матрицы ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Заполнение через половину матрицы, если i + j <= n
// O(n^2 / 2)

int[, ] matrix = new int [n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i + j <= n)
//         {
//             matrix[i, j] = (i + 1) * (j + 1);
//             matrix[j, i] = (i + 1) * (j + 1);
//         }
//         Console.Write((i + 1) * (j + 1) + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Верный вариант

 for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
        Console.Write((i + 1) * (j + 1) + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i , j] + "\t");
    }
    Console.WriteLine();
}