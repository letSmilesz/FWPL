// Не используя рекурсию вывести первые N чисел Фибоначчи

void PrintText(string text)
{
    Console.Write(text);
}

int UserEnterNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

string FibonacciCycle (int n)
{
    string answer = ($"{n} -> 0 ");
    int first = 0;
    int second = 1;
    int actual;
    for (int i = 2; i <= n; i++)
    {
        actual = first + second;
        answer += ($"{actual} ");
        second = first;
        first = actual;
    }
    return answer;
}

PrintText("Введите, сколько первых чисел из последовательности Фибоначчи надо вывести на экран: ");
int n = UserEnterNum();
string ans = FibonacciCycle(n);
Console.WriteLine(ans);
