//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System.Linq.Expressions;

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine()
{
    Console.WriteLine();
}

void EndOnPC()
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
    NewLine();
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

int[,] ProductOfMatrix(int[,] array1, int[,] array2, int row1, int col2)
{
    int[,] result = new int[row1, col2];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int newNum = new int();
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                newNum += array1[i, k] * array2[k, j];
            }
            result[i, j] = newNum;
        }
    }
    return result;
}

PrintText("Введите количество строк, затем столбцов для первой матрицы: ");
int row1 = UserEnter();
int col1 = UserEnter();
PrintText("Введите количество строк, затем столбцов для второй матрицы: ");
int row2 = UserEnter();
int col2 = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();

int[,] matrix1 = CreateMatrixRandom(row1, col1, min, max);
int[,] matrix2 = CreateMatrixRandom(row2, col2, min, max);

PrintArrayMatrix(matrix1);
PrintArrayMatrix(matrix2);

if (col1 != row2) PrintText("Данные матрицы нельзя перемножить.");
else
{
    int[,] resultMatrix = ProductOfMatrix(matrix1, matrix2, row1, col2);
    PrintArrayMatrix(resultMatrix);
}

//EndOnPC();