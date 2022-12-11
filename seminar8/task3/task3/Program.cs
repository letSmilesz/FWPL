//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void PrintArrayCounts(int[,] arr, int min)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i,0] != min - 1 && arr[i,1] != 0) Console.WriteLine($"{arr[i, 0]} повторяется {arr[i,1] + 1} раз");
    }
}

void CreateMatrixRandomWithCheckCounts (int strings, int columns, int min, int max, int[,]array2)
{
    int[,] array = new int[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{array[i,j]} ");
            bool check = false;
            for (int k = 0; k < array2.GetLength(0); k++) 
            { 
                if (array[i,j] == array2[k, 0]) 
                {
                    array2[k,1] += 1;
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                for (int k = 0; k < array2.GetLength(0); k++) 
                { 
                    if (array2[k,0] == min - 1) 
                    {
                        array2[k,0] = array[i,j];
                        break;
                    }
                }
            }
        }
        NewLine();
    }
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

int[,] repeats = new int [rows*col, 2];
for (int i = 0; i < repeats.GetLength(0); i++) //цикл для заполнения массива элементами, которые не могут оказаться в массиве
{
    repeats[i,0] = min - 1;
}

CreateMatrixRandomWithCheckCounts (rows, col, min, max, repeats);
PrintArrayCounts(repeats, min);

Console.Read();