Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
string someNum = "";

while (i <= num)
{
    if (i % 2 == 0)
    {
        someNum = someNum + i + ", ";
    }
    i++;
}

Console.Write (someNum);