//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNum = number;
int sum = 0;

for (; copyNum != 0; copyNum/=10){
    sum += copyNum % 10;
}

Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
