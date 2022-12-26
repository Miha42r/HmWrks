int EjectTwoDigit(int x) //Извлекаем второй разряд
{
    Console.WriteLine("Извлекаем второй разряд");
    int a = (x / 10) % 10;
    return a;
}

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);

if (numb <= 99) //проверяем разрядность числа
{
    Console.WriteLine($"{numb} - у данного числа нет третьего разряда, введите число");
    return;
}
else
{
    Console.WriteLine(EjectTwoDigit(numb));
}