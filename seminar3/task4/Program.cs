﻿//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string str = ($"{num} ->");
for (int i = 1; i <= num; i++){
    double sq = Math.Pow(i, 2);
    str += ($"{sq}, ");
}
Console.WriteLine(str);

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++){
//     double sq = Math.Pow(i, 2);
//     Console.WriteLine($"{i}^2 = {sq}");
// }
