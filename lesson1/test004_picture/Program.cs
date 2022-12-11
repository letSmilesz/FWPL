int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 70, yc = 30;

int x = xa, y = ya;
int count = 0;
Console.Clear();

Console.SetCursorPosition (xa, ya);
Console.WriteLine ("+");

Console.SetCursorPosition (xb, yb);
Console.WriteLine ("+");

Console.SetCursorPosition (xc, yc);
Console.WriteLine ("+");

while (count < 10000)
{
    int random = new Random().Next(0, 3);
    if (random == 0) 
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (random == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if (random == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count += 1;
}
