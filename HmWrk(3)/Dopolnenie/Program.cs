bool SimpleNumber(int numb)
{
    for (int j = 2; j < numb; j++)
    {
        if (numb % j == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите число ");
int numb = int.Parse(Console.ReadLine()!);

for (int i = 1; i < numb; i++)
{
    if (SimpleNumber(i))
    {
        Console.Write($"{i} ");
    }
}
