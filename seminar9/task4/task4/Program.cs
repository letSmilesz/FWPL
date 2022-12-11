//Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5-> 243(3⁵)
//A = 2; B = 3-> 8

int Pow(int a, int b)
{
    if (b == 1) return a;
    else return a * Pow(a, b - 1);
}

int ans = Pow(3, 5);
Console.WriteLine(ans);