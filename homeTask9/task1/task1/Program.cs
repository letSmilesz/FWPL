//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void FindNums (int n)
{
    if (n != 0)
    {
        Console.Write(n);
        FindNums(n - 1);
    }
}
FindNums(5);
Console.WriteLine();
string FindNums2 (int n)
{
    if (n == 1) return "1";
    else return n + FindNums2(n - 1);
}

string ans = FindNums2(5);
Console.Write(ans);