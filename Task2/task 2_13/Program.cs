
internal class Program
{
    private static void Main(string[] args)
    {
        int EjectThirdDigit(int x) 
        {
            Console.WriteLine("Извлекаем третий разряд");
            
            while (x > 999) //уменьшаем до трехзначного числа
            {
                x = x / 10;
            }
            int a = x % 10; //Извлекаем третий разряд
            return a;
        }

        Console.WriteLine("Введите число");
        int numb = int.Parse(Console.ReadLine()!);

        if (numb <= 99) //проверяем разрядность числа
        {
            Console.WriteLine($"{numb} - у данного числа нет третьего разряда, введите число");
            return;
        }
        if (numb >= 999)
        {
            Console.WriteLine(EjectThirdDigit(numb));
        }
        else
        {
            Console.WriteLine(EjectThirdDigit(numb));
        }
    }
}