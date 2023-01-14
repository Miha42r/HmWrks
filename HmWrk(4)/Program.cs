/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int DegreeNumber(int a, int b)
{
    int i = 1;
    int x = a;
    int degree = 1;
    while (i <= b)
    {
        degree = degree * x;
        i = i + 1;
    }
return degree;
}

Console.WriteLine("Введите число необходимое возвести в степень");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень в которую необходимо возвести число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"степень равна {DegreeNumber(a, b)}");