/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SummaNumbers(int m, int n)
{
    if (n <= m) { return m; }
    m = m + (SummaNumbers(m + 1, n));
    return m;
}
Console.WriteLine("Введите начало и окончание ряда чисел, от меньшего к большему");
Console.WriteLine("Input start number");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input end number");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"the sum of the numbers in order = {SummaNumbers(m, n)}");