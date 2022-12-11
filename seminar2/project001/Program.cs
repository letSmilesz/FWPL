Console.Clear();
int num = new Random().Next(10, 100);
int n1 = num / 10;
int n2 = num % 10;
Console.WriteLine(num);
if (n1 > n2) Console.WriteLine("Десятки больше единиц");
else 
{
    Console.WriteLine("Единицы больше десятков");
}