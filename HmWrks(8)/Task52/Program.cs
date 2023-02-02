
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],-2}");
        }
        Console.WriteLine();
    }
}

int[,] SortStringArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[i, j] < arr[i, j + 1])
            {
                int max = arr[i, j + 1];
                arr[i, j + 1] = arr[i, j];
                arr[i, j] = max;
            }
        }
    }
    return arr;
}
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

arr = SortStringArray(arr);
arr = SortStringArray(arr);
PrintArray(arr);