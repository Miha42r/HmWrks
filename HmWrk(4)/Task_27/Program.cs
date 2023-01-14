/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

/*int SummaNumbers1(int numb)
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
*/

int SummaNumbers2(int numb)
{
    string x = numb.ToString();
    int length = x.Length;
    for (int i = 1; i < length; i++)
    {
        int a = numb / 10;
        int b = numb % 10;
        numb = a + b;
    }
    return numb;
}

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);
Console.WriteLine(SummaNumbers2(numb));
//Console.WriteLine(SummaNumbers1(numb));
