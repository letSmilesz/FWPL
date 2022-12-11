//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
void SortRowsOfMatrix (int[,] array, bool toMax)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int numIndex = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (toMax) 
                {
                    if (array[i,k] < array[i,numIndex]) numIndex = k;
                }
                else
                {
                    if (array[i,k] > array[i,numIndex]) numIndex = k;
                }
            }
            int help = array[i,j];
            array[i,j] = array[i,numIndex];
            array[i,numIndex] = help;   
        }
    }
}

void NewLine()
{
    Console.WriteLine();
}

void EndOnPC ()
{
    Console.Read();
}

PrintText("Введите количество строк, затем столбцов: ");
int row = UserEnter();
int col = UserEnter();
PrintText("Введите минимальное случайное число, а затем максимальное: ");
NewLine();
int min = UserEnter();
int max = UserEnter();
PrintText("Хотите отсортировать от меньшего к большему?    y/n");
bool toMax = UserEnter();

int[,] numbers = CreateMatrixRandom(row, col, min, max);
PrintArrayMatrix(numbers);

SortRowsOfMatrix(numbers, toMax);
NewLine();
PrintArrayMatrix(numbers);

EndOnPC();