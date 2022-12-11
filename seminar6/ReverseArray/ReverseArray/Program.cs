//Создать программу на разворот массива
void ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int help = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = help;
    }
}
void FillArrayNum(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
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
PrintText("Введите длину массива: ");
int length = UserEnterNum();
int[] numbers = new int[length];
FillArrayNum(numbers, -10, 10);
PrintArray(numbers);
ReverseArray(numbers);
PrintArray(numbers);