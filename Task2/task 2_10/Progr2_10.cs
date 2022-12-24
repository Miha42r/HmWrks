int EjectTwoDigit(int x) //Извлекаем второй разряд
{
    Console.WriteLine("Извлекаем второй разряд");
    int a = (x / 10) % 10;
    return a;
}

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);
if (numb < 999)
{
    Console.WriteLine(EjectTwoDigit(numb));
}