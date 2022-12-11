//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

string exit = "y";
while (exit == "y"){
    Console.Write("Введите координату x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y:");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x > 0){
        if (y > 0){
            Console.WriteLine("Точка находится в 1-ой четверти.");
        } else {
            Console.WriteLine("Точка находится в 4-ой четверти.");
        }
    } else {
        if (y > 0){
            Console.WriteLine("Точка находится в 2-ой четверти.");
        } else {
            Console.WriteLine("Точка находится в 3-ей четверти.");
        }
    }
    Console.WriteLine("Хотите ввести ещё одну точку? y/n");
    exit = Console.ReadLine();
}