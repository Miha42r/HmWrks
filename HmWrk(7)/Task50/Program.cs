/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет */



int[,] CreateArray(int rows = 3, int col = 4)
{
    Random rnd = new Random();
    int[,] array = new int[rows, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-30, 41);
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
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позицию числа в массиве");
Console.WriteLine("Введите строку");
int rows = Convert.ToInt32(Console.ReadLine()!);
rows = rows -1;

Console.WriteLine("Введите столбец");
int col = Convert.ToInt32(Console.ReadLine()!);
col = col -1;

int[,] array = CreateArray();
PrintArray(array);
int QuantityRows = array.GetUpperBound(0); // количество строк
if ((rows > QuantityRows) || (col > array.GetLength(0)))
{
    Console.WriteLine(" нет такой позиции");
}
else
Console.WriteLine(array[rows, col]);
