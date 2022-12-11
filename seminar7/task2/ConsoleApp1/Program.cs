//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//Aₘₙ = m + n.Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

Console.Write("Введите количество строк, затем столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = i + j;
        Console.Write($"{numbers[i, j]} ");
    }
    Console.WriteLine();
}