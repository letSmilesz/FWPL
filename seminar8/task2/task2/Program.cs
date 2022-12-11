//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. \
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void PrintText(string text)
{
    Console.Write(text);
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

int[,] ChangeRowsAndCols(int[,] arr)
{
    int[,] newArray = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[i,j] = arr[j,i];
        }
    }
    return newArray;
}
void NewLine()
{
    Console.WriteLine();
}

PrintText("Введите количество строк и столбцов массива: ");
NewLine();
int rows = UserEnter();
int col = UserEnter();
PrintText("Введите минимальное случайное число и максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();

int[,] numbers = CreateMatrixRandom(rows, col, min, max);
PrintArrayMatrix(numbers);
NewLine();

if (rows == col)
{
    int[,] newNumbers = ChangeRowsAndCols(numbers);
    PrintArrayMatrix(newNumbers);
}
else PrintText("Поменять строки и столбцы не получится.");

Console.Read();