﻿
Console.WriteLine("Введите номер дня недели от 1 до 7");
short n = short.Parse(Console.ReadLine()!);

if (n<=5 & n>=1)
{
    Console.WriteLine("Будни");
}
else
{
    if (n==6 || n == 7) Console.WriteLine("Выходной");    
}