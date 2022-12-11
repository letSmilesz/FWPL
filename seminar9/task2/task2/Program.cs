//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5-> "1, 2, 3, 4, 5"
//M = 4; N = 8-> "4, 6, 7, 8"

void PrintNum (int m, int n)
{
    if (m <= n)
    {
        Console.Write(m);
        PrintNum(m + 1, n);
    }
}

PrintNum(4, 8);

string PrintNum2 (int m, int n)
{
    if (m == n) return Convert.ToString(m);
    else return m + PrintNum2(m + 1, n);
}

Console.WriteLine();
string ans = PrintNum2(4, 8);
Console.WriteLine(ans);