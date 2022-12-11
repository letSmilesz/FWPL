// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void FillArrayNum(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
}

void PrintText (string text){
    Console.Write(text);
}

int UserEnterNum (){
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int EvenCount (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count+=1;
    }
    return count;
}

PrintText("Введите длину массива: ");
int length = UserEnterNum();
int [] numbers = new int [length];
FillArrayNum(numbers, 100, 999);
int count = EvenCount(numbers);
PrintText("В массиве ");
PrintArray(numbers);
PrintText($"Количество четных чисел: {count}");
