//Программа принимает число и выдает произведение от 1 до числа

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int product = 1;

for (int i = 1; i <= num; i++){
    product *= i;
}

Console.WriteLine(product);