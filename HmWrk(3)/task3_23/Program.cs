void Cube(long i)
{
    for (long index = 1; index <= i; index++)
    {
        long cub = index * index * index;
        Console.WriteLine($"Куб числа {index} равен {cub}");
    }

}


Console.WriteLine("Введите число ");
long i = long.Parse(Console.ReadLine()!);
Cube(i);
