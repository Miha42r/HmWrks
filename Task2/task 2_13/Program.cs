
internal class Program
{
    private static void Main(string[] args)
    {
        int EjectThirdDigit(int x) //Извлекаем третий разряд
        {
            Console.WriteLine("Извлекаем третий разряд");
            int a = x % 10;
            return a;
        }

        int DigitsNumber(int numb) // привожу число к трёхзначному
        {
            Console.WriteLine("Приводим число к трехзначному");
            while (numb > 999)
            {
                numb = numb / 10;
            }
            return numb;
        }

        Console.WriteLine("Введите число");
        int numb = int.Parse(Console.ReadLine()!);

        if (numb < 99) //проверяем разрядность числа
        {
            Console.WriteLine($"{numb} - у данного числа нет третьего разряда, введите число");
            return;
        }
        if (numb > 999)
        {
            numb = DigitsNumber(numb);
            Console.WriteLine(EjectThirdDigit(numb));
        }
        else
        {
            Console.WriteLine(EjectThirdDigit(numb));
        }
    }
}