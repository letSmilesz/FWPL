//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим 
//следующий массив:
//9 4 2
//2 2 6
//3 4 7

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

void PrintArrayMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
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

int FindRowColWithMin (int[,] array, bool row)
{   
    int min = array[0,0];
    int minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                if (row) minIndex = i;
                else minIndex = j;
            }
        }
    }
    return minIndex;
}

int[,] DeleteRowColWithMin(int[,] array)
{
    int rowWithMin = FindRowColWithMin(array, true);
    int colWithMin = FindRowColWithMin(array, false);
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    int k = 0; //индексы для нового массива
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != rowWithMin)
        {
            l = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != colWithMin)
                {
                    newArray[k,l] = array[i,j];
                    l++;
                }
            }
            k++;
        }
    }
    return newArray;
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
numbers = DeleteRowColWithMin(numbers);
PrintArrayMatrix(numbers);

Console.Read();