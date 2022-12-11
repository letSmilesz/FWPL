// Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}


void PrintText(string text)
{
    Console.Write(text);
}

int UserEnterNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string FindNum(int[] arr, int num)
{
    string answer = "Такого числа нет.";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            answer = ($"Минимум одно число {num} есть в массиве, первое находится на позиции {i + 1}.");
            return answer;
        }
    }
    return answer;
}

PrintText("Введите длину массива: ");
int n = UserEnterNum();
int[] numbers = new int[n];
PrintText("Введите минимальное случайное число: ");
int minNum = UserEnterNum();
PrintText("Введите максимальное случайное число: ");
int maxNum = UserEnterNum();

FillArray(numbers, minNum, maxNum);
PrintText("Какое число искать в массиве? ");
int num = UserEnterNum();
PrintArray(numbers);
string answer = FindNum(numbers, num);
PrintText(answer);