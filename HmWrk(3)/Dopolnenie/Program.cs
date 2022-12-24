void SimpleNumber(long i)
{
    for (long index = 1; index <= i; index++)
    {
        if ((true) == (index % 2) > 0)
        {
        Console.WriteLine($"{index} число простое");
        }
    }

}


Console.WriteLine("Введите число ");
long i = long.Parse(Console.ReadLine()!);
SimpleNumber(i);




