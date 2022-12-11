// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.

void FillArray(int[] arr, int min, int max)
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



PrintText("Введите длину массива: ");
int n = UserEnterNum();
int [] numbers = new int [n];
PrintText("Введите минимальное случайное число: ");
int minNum = UserEnterNum();
PrintText("Введите максимальное случайное число: ");
int maxNum = UserEnterNum();

FillArray(numbers, minNum, maxNum);
PrintArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}
PrintArray(numbers);