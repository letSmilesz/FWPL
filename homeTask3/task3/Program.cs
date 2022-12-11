// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
string exit = "";
while (exit != "n"){
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    //вариант с простым выведением "таблицы"
    // for (int i = 1; i <= num; i++){
    //     Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    // }

    //вариант с выведением "как в примере"(3 -> 1, 8, 27)
    string str = ($"{num} -> ");
    for (int i = 1; i <= num; i++){
        str += ($"{Math.Pow(i, 3)}, ");
    }
    Console.WriteLine(str);
    Console.WriteLine("Хотите ввести ещё одно число? y/n");
    exit = Console.ReadLine();
}