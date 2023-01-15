/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] CreateArray(int length, int min = -10 , int max = 9)
{
    Random rnd = new Random();
    int[] collection = new int[length];
    for (int i = 0; i < length; i++)
    {
        collection[i] = rnd.Next(min, max);
    }
    return collection;
}

void CompozitionElementsArray(int[] array)
{
    int len = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        int x = array[i] * array[len - i];
        Console.Write(x + " ");
    }
    //Console.WriteLine();
    if (array.Length % 2 != 0)
    {
        Console.Write(array[len / 2]);
        //Console.WriteLine($"значение среднего элемента: {array[len / 2]}");
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32(Console.ReadLine()!);
int[] array = CreateArray(length);
PrintArray(array);

Console.WriteLine("---------");

CompozitionElementsArray(array);