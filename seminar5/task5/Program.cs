// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

void PrintProductOfPairs (int [] arr){
    for (int i = 0; i < arr.Length/2; i++)
    {
        Console.Write($"{arr[i] * arr[arr.Length - 1 - i]} ");
    }
    Console.WriteLine();
    if (arr.Length % 2 != 0) Console.WriteLine($"У одного числа нет пары, это число {arr[arr.Length /2]}.");
}

PrintText("Введите длину массива: ");
int n = UserEnterNum();
int[] numbers = new int[n];
PrintText("Введите минимальное случайное число: ");
int minNum = UserEnterNum();
PrintText("Введите максимальное случайное число: ");
int maxNum = UserEnterNum();

FillArray(numbers, minNum, maxNum);
PrintArray(numbers);
PrintProductOfPairs(numbers);
