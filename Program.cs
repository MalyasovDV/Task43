float Input()
{
    float number = float.Parse(Console.ReadLine());
    return number;
}

float FindY(float k,float b, float x)
{
    float y = k*x + b;
    return y;
}

void FindIntersectionPoint(float k1, float b1, float k2, float b2)
{
    float x = (b2-b1)/(k1-k2);

    Console.WriteLine("(" + x + ";" + FindY(k1,b1,x) + ")");
}

float k1, b1, k2, b2;

k1 = Input();
b1 = Input();
k2 = Input();
b2 = Input();

Console.WriteLine(k1 + " " + b1 + " " + k2 + " " + b2);

FindIntersectionPoint(k1, b1, k2, b2);