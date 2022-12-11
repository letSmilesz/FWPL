// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] numbers = new int [8];
Console.Write("В массиве будут числа от .. до ..");
int minNum = Convert.ToInt32(Console.ReadLine());
int maxNum = Convert.ToInt32(Console.ReadLine());
string answer = "Массив: ";
for (int i = 0; i < numbers.Length; i++){
    numbers[i] = new Random().Next(minNum, maxNum + 1);
    answer += ($"{numbers[i]}, ");
}
Console.WriteLine(answer);