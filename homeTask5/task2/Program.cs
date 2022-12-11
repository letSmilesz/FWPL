// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArrayNum(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
}

void PrintNum (int a){
    Console.WriteLine(a);
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

int FindSum(int [] arr, bool a) //а - четные - да, нечетные - нет
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (a == true && i % 2 == 0) sum+= arr[i];
        else if (a == false && i % 2 != 0) sum += arr[i];
    }
    return sum;
}

PrintText("Введите длину массива: ");
int length = UserEnterNum();
PrintText("Введите минимальное случайное число: ");
int min = UserEnterNum();
PrintText("Введите максимальное случайное число: ");
int max = UserEnterNum();
int [] numbers = new int [length];
FillArrayNum(numbers, min, max);
PrintArray(numbers);
int sum = FindSum(numbers, false);
PrintNum(sum);