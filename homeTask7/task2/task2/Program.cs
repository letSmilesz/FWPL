﻿//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

void PrintText(string text)
{
    Console.Write(text);
}

dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        int b = Convert.ToInt32(a);
        if (b >= 0 || b < 0) return b;
        else return a;
    }
    else
    {
        a = "exit";
        return a;
    }
}

void PrintArrayMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        NewLine();
    }
}

int[,] CreateMatrixRandom(int strings, int columns, int min, int max)
{
    int[,] array = new int[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void NewLine()
{
    Console.WriteLine();
}

int FindSumDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum+= array[i, j];
        }
    }
    return sum;
}

PrintText("Введите количество строк: ");
int str = UserEnter();
PrintText("Введите количество столбцов: ");
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();

int[,] numbers = CreateMatrixRandom(str, col, min, max);
PrintArrayMatrix(numbers);
PrintText("Введите индекс элемента, который ищем без пробелов цифрами: ");
int findIndex = UserEnter();
//if (findIndex/10 <= numbers.GetLength(0) && findIndex%10 <= numbers.GetLength(1))
if (findIndex / 10 < str && findIndex % 10 < col) PrintText($"В этом элементе " +
                                                  $"лежит число {numbers[findIndex / 10, findIndex % 10]}.");
else PrintText("Такого элемента нет.");