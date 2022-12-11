// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

void FillArray(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
}

void PrintNum (int a){
    Console.WriteLine(a);
}

int [] numbers = new int [123];
FillArray(numbers, 0, 140);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10 && numbers[i] < 100) count++;
}
PrintNum(count);
