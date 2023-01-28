/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] CreateArray(int rows = 3, int col = 4)
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
            Console.Write($"{array[i, j], -2}");
        }
        Console.WriteLine();
    }
}

void ArifmeticMeanColumns(int[,] array, int rows)
{
int sum = 0;
double arif = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }
    Console.Write($"{(arif = sum / rows):f2} ");
    }
}

Console.WriteLine("Введите количество строк и столбцов массива");
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine()!);

int[,] mass = CreateArray(rows, col);
PrintArray(mass);
Console.WriteLine();
ArifmeticMeanColumns(mass, rows);