/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] AddArray()
{
    int[] array = new int[8];
    Random rnd = new Random();
    int i = 0;
    while (i < array.Length)
    {
        array[i] = rnd.Next(0, 99);
        i++;
    }
return array;
}

void PrintArray(int[] arr)
{
    foreach (var i in arr)
    {
        Console.Write(i + " ");
    }
}

Console.WriteLine("Программа создает массив из 8 случайных элементов и выводит их на экран");

int[] arr = AddArray();
//Выводим массив одним из способов:
PrintArray(arr);

/*string s = string.Join(" ", arr);
Console.WriteLine(s);
*/


 
