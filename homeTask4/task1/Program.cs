//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число, которое нужно возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

//int Math.Pow(number, degree){
int copyNum = number;
for (int i = 1; i < degree; i++){
    number *= copyNum;
}
//}
Console.WriteLine($"{copyNum}^{degree} = {number}");