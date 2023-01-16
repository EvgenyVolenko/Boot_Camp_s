using static Sorting;

int size = 100;

var arr = size.CreateArray(min: -100, max: 100)
            .Show()
            .SortQuick(0, size - 1)
            .Show()
            ;

Console.WriteLine("+");
