// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

void FillArrayNum (double [] arr, double min, double max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
    }
}

void PrintNum (double a){
    Console.WriteLine(a);
}

void PrintText (string text){
    Console.Write(text);
}

int UserEnterNum (){
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

double UserEnterDouble (){
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}

void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double FindMax (double [] arr){
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin (double [] arr){
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

PrintText("Введите длину массива: ");
int length = UserEnterNum();
PrintText("Введите минимальный случайное число: ");
double min = UserEnterDouble();
PrintText("Введите максимальное случайное число: ");
double max = UserEnterDouble();

double [] numbers = new double [length];
FillArrayNum(numbers, min, max);
PrintArray(numbers);
double minNum = FindMin(numbers);
PrintNum(minNum);
double maxNum = FindMax(numbers);
PrintNum(maxNum);
double diff = maxNum - minNum;
PrintNum(diff);
