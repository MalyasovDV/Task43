float Input()
{
    float number = float.Parse(Console.ReadLine());
    return number;
}

float FindY(ref float k,ref float b, ref float x)
{
    float y = k*x + b;
    return y;
}

void FindIntersectionPoint(ref float k1, ref float b1, ref float k2, ref float b2)
{
    float x = (b2-b1)/(k1-k2);

    Console.WriteLine("(" + x + ";" + FindY(ref k1, ref b1, ref x) + ")");
}

float k1, b1, k2, b2;

k1 = Input();
b1 = Input();
k2 = Input();
b2 = Input();

Console.WriteLine(k1 + " " + b1 + " " + k2 + " " + b2);

FindIntersectionPoint(ref k1, ref b1, ref k2, ref b2);