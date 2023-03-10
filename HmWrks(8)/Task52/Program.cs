/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] CreateArray(int rows = 3, int col = 3)
{
    Random rnd = new Random();
    int[,] array = new int[rows, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

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
    for (int a = 0; a < arr.Length; a++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int max = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = max;
                }
            }
        }
    }
    return arr;
}

int[,] arr = CreateArray();
PrintArray(arr); // выводим полученный массив
Console.WriteLine("Полученный массив отсортирован по строчно по убыванию");
//int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
arr = SortStringArray(arr);
PrintArray(arr);    