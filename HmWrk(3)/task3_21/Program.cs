//Вычисление растояния по координатам пространства.
double DistanseCoordinate()
{
    Console.WriteLine("Coordinate A");

    double xa = double.Parse(Console.ReadLine()!);
    double ya = double.Parse(Console.ReadLine()!);
    double za = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Coordinate B");

    double xb = double.Parse(Console.ReadLine()!);
    double yb = double.Parse(Console.ReadLine()!);
    double zb = double.Parse(Console.ReadLine()!);

    double Dist = Math.Sqrt(((xa - xb) * (xa - xb)) + ((ya - yb) * (ya - yb)) + ((za - zb) * (za - zb)));
    return Dist;
}

Console.WriteLine("Вычисление растояния между двумя точками по координатам(3D)");
Console.WriteLine(DistanseCoordinate());
