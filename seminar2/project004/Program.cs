Console.Write("Введите число 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());


if ((num1 % 7 == 0) && (num1 % 23 == 0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}