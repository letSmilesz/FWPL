//Программа принимает число и выдает кол-во цифр в числе

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int copyNum = num;
int count = 0;

for (; copyNum != 0; count++){
    copyNum /= 10;
}

Console.WriteLine($"В числе {num} имеется {count} цифры.");