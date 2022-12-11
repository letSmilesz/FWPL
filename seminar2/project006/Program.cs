Console.Write("Введите число 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3 : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (num1 > 0) sum+=num1;
if (num2 > 0) sum+=num2;
if (num3 > 0) sum+=num3;

Console.WriteLine(sum);