Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = (num % 100) / 10;
Console.WriteLine(n1);