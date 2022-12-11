Console.Write("Введите число 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num = num1 % num2;

if (num != 0)
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Кратно");
}