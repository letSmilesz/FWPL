// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
}

void Print (int a){
    Console.WriteLine(a);
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int FindSum(int [] arr, bool a) //а - четные - да, нечетные - нет
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (a == true && arr[i] > 0) sum+= arr[i];
        else if (a == false && arr[i]< 0) sum += arr[i];
    }
    return sum;
}

int [] numbers = new int [12];
FillArray(numbers, -9, 9);
PrintArray(numbers);
bool a = true;
int moreZero = FindSum(numbers, a);
Print(moreZero);
a = false;
int lessZero = FindSum(numbers, a);
Print(lessZero);
