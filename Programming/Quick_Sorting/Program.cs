using static Sorting;

int size = 1_000_000;

var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;

Console.WriteLine("+");
