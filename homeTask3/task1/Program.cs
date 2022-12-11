// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

string exitCycle = "";
while (exitCycle != "n"){
    Console.Write("Введите пятизначное(необязательно) число: ");
    long num = Convert.ToInt64(Console.ReadLine());
    //вариант для 5ти значного числа
    // if ((num / 10000) == (num %10)){
    //     if ((num/1000 %10) == (num % 100 /10)){
    //         Console.WriteLine("Это число палиндром");
    //     } else {
    //         Console.WriteLine("Это число не палиндром");
    //     }
    // } else {
    //    Console.WriteLine("Это число не палиндром");
    // }

    //вариант для числа в пределах int64
    long n = num;
    int count = 0; //количество цифр в числе
    long div = 1; //переменная для нахождения чисел слева
    while (n != 0){
        n /= 10;
        count++;
        if (count > 1){
            div *= 10;
        }
    }
    int exit = 0; //проверка на break
    long remDiv = 10; //переменная для остатка от деления
    long div2 = 1; //переменная для отбрасывания лишних чисел справа
    for (int i = 0; i < count/2; i++){
        if ((num / div % 10) != (num % remDiv / div2)){
            exit = 1;
            break;
        }
        remDiv *= 10;
        div /= 10;
        div2 *= 10;
    }
    if (exit == 0){
        Console.WriteLine($"{num} - число палиндром");
    } else {
        Console.WriteLine($"{num} - не является палиндромом");
    }
    Console.WriteLine("Хотите ввести ещё одно число? y/n");
    exitCycle = Console.ReadLine();
}