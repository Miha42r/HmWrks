/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int SummaNumbers(int numb)
{
    string n = Convert.ToString(numb);
    int length = n.Length;
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        summ = int.Parse(n[i].ToString()) + summ;
    }

return summ;    
}

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);

Console.WriteLine(SummaNumbers(numb));
