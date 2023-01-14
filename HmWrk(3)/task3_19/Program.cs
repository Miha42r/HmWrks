// Программа поиска числа палиндром.

void Palindrom(int x)
{
    string a = Convert.ToString(x);
    int e = x % 10;
    x = x / 10;
    int d = x % 10;
    x = x / 10;
    int c = x % 10;
    x = x / 10;
    int b = x % 10;
    x = x / 10;

    string x_mirror = string.Concat(e, d, c, b, x);
    if (a == x_mirror)
    {
        Console.WriteLine($"{x_mirror} - число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{x_mirror} - число не является палиндромом");
    }

}

Console.WriteLine("Введите пятизначное число");
int x = int.Parse(Console.ReadLine()!);

string str = Convert.ToString(x);
if (str.Length == 5)
{
    Palindrom(x);
}
else
{
    Console.WriteLine("Введите пожалуйста ПЯТИзначное число");
}