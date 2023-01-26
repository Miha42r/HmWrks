
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