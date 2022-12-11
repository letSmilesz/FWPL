void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength (0); i++)
    {
        for (int j = 0; j < arr.GetLength (1-1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write(arr[i, arr.GetLength(1 - 1)]);
        Console.WriteLine();
    }
}

void FillArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);