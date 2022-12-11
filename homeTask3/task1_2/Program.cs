string exit = "";
while (exit != "n"){
    Console.Write("Введите число: ");
    long number = Convert.ToInt64(Console.ReadLine());

    long copyNum = number; //переменная для издевательств
    long num = 0; //тут будет храниться одна цифра
    long secondNumber = 0; //переменная для сравнения результата

    for (; copyNum != 0; copyNum /= 10){
        num = copyNum % 10;
        secondNumber = secondNumber * 10 + num;
    }

    if (secondNumber == number){
        Console.WriteLine("Это число палиндром");
    } else {
        Console.WriteLine("Это число не является палиндромом");
    }
    Console.Write("Хотите ввести ещё одно число? y/n           ");
    exit = Console.ReadLine();
}