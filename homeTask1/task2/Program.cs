Console.Write ("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int numMax;
if ((num1 > num2) && (num1 > num3))
{
    numMax = num1;
}
else if (num2 > num3)
{
    numMax = num2;
}
else
{
    numMax = num3;
}

Console.WriteLine ("Самое большое число - " + numMax);