//Программа на вход принимает число, выдает сумму чисел от 1 до числа

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= num; i++){
    sum += i;
}
Console.WriteLine($"{num} -> {sum}");