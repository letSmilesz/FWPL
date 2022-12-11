int Factorial (int n)
{
    if (n == 1 || n == 2)
    {
        Console.WriteLine($"{n}! = {n} * {n - 1}!");
        return 1;
    }
    else
    {
        Console.WriteLine($"{n}! = {n} * {n - 1}!");
        return n * Factorial(n - 1);
    }
}

int f = Factorial(10);
Console.WriteLine(f);