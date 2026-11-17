using Geometry.Lib;

Triangle t = new Triangle(3, 4, 5);
Console.WriteLine(t);
Console.WriteLine($"Perimeter: {t.Perimeter()}");
Console.WriteLine($"Longest side: {t.LongestSide}");

Triangle e = new Triangle(2);
Console.WriteLine(e);
Console.WriteLine($"Number of sides: {e.NumberOfSides}");
