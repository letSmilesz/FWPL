//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1


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
        Console.WriteLine();
    }
}

int[,] CreateMatrixRandom (int strings, int columns, int min, int max)
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

PrintText("Введите количество строк: ");
int str = UserEnter();
PrintText("Введите количество столбцов: ");
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
int min = UserEnter();
int max = UserEnter();

int[,] numbers = CreateMatrixRandom(str, col, min, max);
PrintArrayMatrix(numbers);