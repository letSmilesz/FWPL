//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine()
{
    Console.WriteLine();
}

void EndOnPC ()
{
    Console.Read();
}


dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        if (int.TryParse(a, out int n))
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        else if (a == "y") return true;
        else if (a == "n") return false;
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

int FindMinIndex (int[] arr)
{
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex]) minIndex = i;
    }
    return minIndex;
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

void FindMinSum (int[,] array, bool rows)
{
    int[] amounts = new int[] {};
    if (rows) amounts = new int[array.GetLength(0)];
    else amounts = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rows) amounts[i] += array[i, j];
            else amounts[j] += array[i, j];
        }
    }
    int minSumIndex = FindMinIndex(amounts);
    NewLine();
    if (rows) PrintText($"Самая маленькая сумма чисел находится в {minSumIndex + 1} строке.");
    else PrintText($"Самая маленькая сумма чисел находится в {minSumIndex + 1} столбце.");
}

PrintText("Введите количество строк, затем столбцов: ");
int row = UserEnter();
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();
PrintText("Хотите найти минимальную сумму в строках?    y/n");
bool rows = UserEnter();

int[,] numbers = CreateMatrixRandom(row, col, min, max);
PrintArrayMatrix(numbers);
FindMinSum(numbers, rows);

EndOnPC();