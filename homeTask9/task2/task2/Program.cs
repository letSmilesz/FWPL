//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int FindSum (int m, int n)
{
    if (m == n) return m;
    else return m + FindSum(m + 1, n);
}

int ans = FindSum(1, 15);
Console.Write (ans);