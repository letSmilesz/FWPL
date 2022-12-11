//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

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

void PrintArrayMatrix(double[,] arr)
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

double[,] CreateMatrixRandomDouble(int strings, int columns, double min, double max)
{
    double[,] array = new double[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (max + min) - min, 2);
        }
    }
    return array;
}

void NewLine()
{
    Console.WriteLine();
}

PrintText("Введите количество строк: ");
int str = UserEnter();
PrintText("Введите количество столбцов: ");
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();

double[,] numbers = CreateMatrixRandomDouble(str, col, min, max);
PrintArrayMatrix(numbers);