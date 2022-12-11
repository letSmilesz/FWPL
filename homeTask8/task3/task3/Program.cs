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
PrintText("Что вы хотите сделать с матрицами? 1 - сложить, 2 - вычесть, 3 - умножить, 4 - разделить ");
int action = UserEnter();

int firstCycle = row2;
int secondCycle = col2;
if (row1 > row2)
{
    firstCycle = row1;
}
if (col1 > col2)
{
    secondCycle = col1;
}
int[,] matrix1 = CreateMatrixRandom(row1, col1, min, max);
int[,] matrix2 = CreateMatrixRandom(row2, col2, min, max);

    int[,] matrix3 = new int[firstCycle, secondCycle];
for (int i = 0; i < firstCycle; i++)
{
    for (int j = 0; j < secondCycle; j++)
    {
        try
        {
            if (action == 1) matrix3[i,j] = matrix1[i,j] + matrix2[i,j];
            else if (action == 2) matrix3[i,j] = matrix1[i,j] - matrix2[i,j];
            else if (action == 3) matrix3[i,j] = matrix1[i,j] * matrix2[i,j];
            else if (action == 4) matrix3[i,j] = matrix1[i,j] / matrix2[i,j];
        }
        catch (System.IndexOutOfRangeException)
        {
            if (i > row2 - 1 && j > col2 - 1) matrix3[i, j] = matrix1[i, j];
            else if (i > row1 - 1 && j > col1 - 1) matrix3[i, j] = matrix2[i, j];
            else if (i > row1 - 1 && j > col2 - 1
                || i > row2 - 1 && j > col1 - 1) matrix3[i, j] = 0;
            else if (i > row2 - 1 || j > col2 - 1) matrix3[i, j] = matrix1[i, j];
            else if (i > row1 - 1 || j > col1 - 1) matrix3[i, j] = matrix2[i, j];
        }
    }
}

PrintArrayMatrix(matrix1);
PrintArrayMatrix(matrix2);
PrintArrayMatrix(matrix3);

//EndOnPC();