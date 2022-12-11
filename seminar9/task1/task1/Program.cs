//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6

void PrintNum (int n)
{
    if (n != 1)
    {
        PrintNum (n - 1);
    }
    Console.Write(n);
}

PrintNum(5);

string PrintNum2 (int n)
{
    if (n == 1) return "1";
    else return PrintNum2(n - 1) + n;
}
Console.WriteLine();
string ans = PrintNum2(5);
Console.WriteLine(ans);