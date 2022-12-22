// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.WriteLine("Введите первое число для сравнения");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int b = int.Parse(Console.ReadLine());

if (a > b) 
    {
        Console.WriteLine($"{a} больше {b}");
    }
else
        Console.WriteLine($"{b} больше {a}");
*/

/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int a = 2; int b = 3; int c = 7; int max = 0;

if (a > b)
    {max = a;}
else
    {max = b;}
if (max > c)
    {}
else
    {max = c;}
Console.WriteLine(max);
