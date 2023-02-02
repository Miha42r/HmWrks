/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void SortStringArray(int[,] arr)
{
    int[] sumString = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumString[i] = sumString[i] + arr[i, j];
        }
        Console.WriteLine(sumString[i]);
    }
    int min = -1;
    for (var i = 0; i < sumString.Length; i++)
    {
        for (var j = 1; j < sumString.Length-1; j++)
        {
            if (sumString[i] < sumString[j])
            {
                min = i;
            }
        }

    }
    Console.WriteLine($"минимальная сумма в строке c позицией № {min}");
}
//int[,] arr = CreateArray();
//PrintArray(arr); // выводим полученный массив
//Console.WriteLine("Полученный массив отсортирован по строчно по убыванию");
int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
SortStringArray(arr);
//PrintArray(arr);