static TTRiangle[] GenerateRandomTriangles(uint n, double maxSideLen) {
    if (maxSideLen < TTRiangle.EPSILON) {
        throw new ArgumentException("maxSideLen must be bigger than epsilon");
    }
    TTRiangle[] triangles = new TTRiangle[n];
    Random rand = new();
    for (int i = 0; i < n; i++)
    {
        var selection = rand.Next(1, 4);
        switch (selection) {
            case 1:
                var side = rand.NextDouble() * (maxSideLen - TTRiangle.EPSILON) + TTRiangle.EPSILON;
                triangles[i] = new TEqTriangle(side);
                break;
            case 2:
                var cat1 = rand.NextDouble() * (Math.Sqrt(maxSideLen)/Math.Sqrt(2) - TTRiangle.EPSILON) + TTRiangle.EPSILON;
                var cat2 = rand.NextDouble() * (Math.Sqrt(maxSideLen)/Math.Sqrt(2)- TTRiangle.EPSILON) + TTRiangle.EPSILON;
                triangles[i] = new TRightTriangle(cat1, cat2);
                break;
            case 3:
                var baseSide = rand.NextDouble() * (maxSideLen * 0.5 - TTRiangle.EPSILON) + TTRiangle.EPSILON;
                var leg = rand.NextDouble() * (maxSideLen - baseSide * 0.5) + baseSide * 0.5;
                triangles[i] = new TIsoTriangle(baseSide, leg);
                break;
        }
    }
    return triangles;
}

uint n = 10;
int maxSideLen = 20;

var triangles = GenerateRandomTriangles(n, maxSideLen);
Console.WriteLine($"Generated {n} random triangles\n");

int triNum = 1;
foreach (var item in triangles) {   
    Console.WriteLine($"#### Triangle {triNum} ####");
    Console.WriteLine(item);
    if (item.GetType() == typeof(TEqTriangle)) {
        Console.WriteLine("Detected Equilateral Triangle. Calculating Area...");
        Thread.Sleep(2000);
        Console.WriteLine($"--> Area = {item.GetArea()}");
    } else if (item.GetType() == typeof(TRightTriangle)) {
        Console.WriteLine("Detected Right Triangle. Calculating Area...");
        Thread.Sleep(2000);
        Console.WriteLine($"--> Area = {item.GetArea()}");
    } else {
        Console.WriteLine("Detected Isoceles Triangle. Calculating Perimeter...");
        Thread.Sleep(2000);
        Console.WriteLine($"--> Perimeter = {item.GetPerimeter()}");
    }
    Console.WriteLine("\n");
    triNum++;
}