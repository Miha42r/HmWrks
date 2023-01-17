/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] CreateArray(int length = 6)
{
    int i = 0;
    Random rnd = new Random();
    double[] array = new double[length];
    while (i < length)
    {
        array[i] = rnd.NextDouble() * 15;
        i++;
    }
    return array;
}
void PrintArray(double[] array)
{
    //Console.Write(string.Join(" ", array));

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f3}" + " ");
    }
    Console.WriteLine();
}
void DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    double razn = max - min;
    Console.WriteLine($"min = {min:f3} max = {max:f3}");
    Console.WriteLine($"{razn:f3}");
}

Console.WriteLine("Lenght Array?");
int lenght = Convert.ToInt32(Console.ReadLine()!);
double[] array = new double[lenght];
array = CreateArray(lenght);
Console.WriteLine("Ready Array");
PrintArray(array);
DifferenceMinMax(array);
