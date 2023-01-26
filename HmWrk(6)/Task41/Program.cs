
int QuantityPositiveNumb()
{
    string s;
    int count = 0;
    do
    {
        s = Console.ReadLine()!;
        if (s != "")
        {
            if (Convert.ToInt32(s) > 0)
            {
                count++;
            }
        }

    } while (s != "");

    return count;
}
Console.WriteLine("Введите числа, по окончанию ввода нажмите 'Enter'");
Console.WriteLine("Введено положительных чисел: " + QuantityPositiveNumb());

//Вариант к разбирательству

/*string[] AS;
int count;
string s;
string[] AS2;

Console.WriteLine("Введите числа, по окончанию ввода нажмите 'Enter'");

count = 0; // обнулить количество строк
AS = new string[count]; // выделить память для 0 строк

do
{
    s = Console.ReadLine()!;
    if (s != "")
    {
        count++;
        AS2 = new string[count];

        for (int i = 0; i < AS2.Length - 1; i++)
            AS2[i] = AS[i];
            AS2[count - 1] = s;

        AS = AS2;
    }
} while (s != "");

// 3. Вывод массива строк AS в цикле
int p = 0;
for (int i = 0; i < AS.Length; i++)
{

    int d = Convert.ToInt32(AS[i]);
    if (d > 0)
    {
        p++;
    }

}
Console.WriteLine("Количество положительных = " + p);
*/ 