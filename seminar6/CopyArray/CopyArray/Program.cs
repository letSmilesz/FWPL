// Напишите программу, которая будет создавать поэлементную копию массива

void FillArrayNum(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintText(string text)
{
    Console.Write(text);
}

int UserEnterNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void CopyArray (int[] arr, int[] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
}

PrintText("Введите длину массива: ");
int length = UserEnterNum();
int[] num1 = new int[length];
int[] num2 = new int[length];
FillArrayNum(num1, -10, 10);
PrintText("Вот первый массив: ");
PrintArray(num1);
PrintText("Вот второй массив: ");
PrintArray(num2);
CopyArray(num1, num2);
PrintText($"Вот снова первый массив: ");
PrintArray(num1);
PrintText("И снова второй массив: ");
PrintArray(num2);

