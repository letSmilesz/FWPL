//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

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

void NewLine()
{
    Console.WriteLine();
}

void FillTrianglePascal(int[,] array)
{ 
    for (int i = 1; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j < triangle.GetLength(1); j++)
        {
            if (j == 0) triangle[i, j] = triangle[i - 1, j + 1];
            else if (j == triangle.GetLength(1) - 1) triangle[i, j] = triangle[i - 1, j - 1];
            else triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j + 1];
        }
    }
}

void PrintTrianglePascal(int[,] array)
{ 
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j < triangle.GetLength(1); j++)
        {
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j]}");
            else Console.Write(" ");
        }
        NewLine();
    }
}

PrintText("Введите сколько строк треугольника Паскаля нужно вывести: ");
int rows = UserEnter();
int[,] triangle = new int[rows, rows * 2 - 1];
triangle[0, rows - 1] = 1;
FillTrianglePascal(triangle);
PrintTrianglePascal(triangle);

Console.ReadLine();