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
/*
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
*/

/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/*
int N;
N = int.Parse(Console.ReadLine());
if((N%2)==0)
    {Console.WriteLine($"{N}, чётное");}
else{Console.Write($"{N}, не четное");}
*/

/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int N = int.Parse(Console.ReadLine());

for (int i = 0; i <= N; i++)
{
    if ((i%2)==0)
    {
        Console.WriteLine(i);
    }
}