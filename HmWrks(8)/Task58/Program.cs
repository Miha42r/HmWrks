/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


int[,] matrix1 = { { 2, 4 }, { 3, 4 } };
int[,] matrix2 = { { 3, 2 }, { 3, 3 } };


int[,] arr = DivMatrix(matrix1, matrix2);

for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("|");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j],-2}|");
    }
    Console.WriteLine();
}