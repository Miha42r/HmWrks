/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int length, int min = 100, int max = 999)
{
    Random rnd = new Random();
    int[] collection = new int[length];
    for (int i = 0; i < length; i++)
    {
        collection[i] = rnd.Next(min, max);
    }
    return collection;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int QuantityEvenNumbers(int[] array) //количество четных элементов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
return count;
}
int SummaElementsEvenIndex(int[] array) //сумма элементов на четных позициях
{
    int summ=0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        summ = array[i] + summ;
    }
return summ;
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine()!);

int[] array = new int[length];
array = CreateArray(length);
PrintArray(array);

Console.WriteLine($"Количество четных элементов: {QuantityEvenNumbers(array)}");
Console.WriteLine($"Сумма элементов четных индексов: {SummaElementsEvenIndex(array)}");