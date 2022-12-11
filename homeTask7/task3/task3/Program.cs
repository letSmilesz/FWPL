//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void NewLine()
{
    Console.WriteLine();
}

void FindAverage(int[,] arr, bool horizontal)
{
    NewLine();
    double average = 0;
    int firstCycle = arr.GetLength(1);
    int secondCycle = arr.GetLength(0);
    if (horizontal)
    {
        firstCycle = arr.GetLength(0);
        secondCycle = arr.GetLength(1);
    }
    for (int i = 0; i < firstCycle; i++)
    {
        int sum = 0;
        int j = 0;
        for (; j < secondCycle; j++)
        {
            if (horizontal) sum += arr[i, j];
            else sum += arr[j, i];
        }
        average = Convert.ToDouble(sum) / Convert.ToDouble(j);
        PrintText($"{average} ");
    }
    NewLine();
}

PrintText("Введите количество строк: ");
int str = UserEnter();
PrintText("Введите количество столбцов: ");
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();
PrintText("Вы хотите найти среднее арифметическое в строках?     y/n");
string yes = UserEnter();
bool horizontal;
if (yes == "y") horizontal = true;
else horizontal = false;

int[,] numbers = CreateMatrixRandom(str, col, min, max);
PrintArrayMatrix(numbers);
FindAverage(numbers, horizontal);
