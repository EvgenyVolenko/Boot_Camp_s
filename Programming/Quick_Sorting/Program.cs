using static Sorting;

int size = 30;

var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show();
