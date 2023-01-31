void PointOfIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают, имеют множество точек пересечения");
    }

    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");        
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения M, прямых A и B, имеет координаты ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    }

}

//Console.Write("Введите коэффициенты k1 и b1 прямой A");
int k1 = 5;
int b1 = 2;

//Console.Write("Введите коэффициенты k2 и b2 прямой B");
int k2 = 9;
int b2 = 4;
PointOfIntersection(k1, b1, k2, b2);