//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int FindSum (int n)
{
    if (n / 10 == 0) return n;
    else return FindSum (n / 10) + n % 10;
}

int ans = FindSum(453);
Console.WriteLine (ans);