/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int length)
{
    Random rnd = new Random();
    int[] collection = new int[length];
    for (int i = 0; i < length; i++)
    {
        collection[i] = rnd.Next(-10, 11);
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

int SummaElementsEvenIndex(int[] array)
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

Console.WriteLine($"Сумма элементов четных индексов: {SummaElementsEvenIndex(array)}");
