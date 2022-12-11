Console.Write("Введите x1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x3 : ");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x4 : ");
int x4 = Convert.ToInt32(Console.ReadLine());

int help = 0;
if (x1 > x2) {
    help = x1;
    x1 = x2;
    x2 = help;
}
if (x3 > x4) {
    help = x3;
    x3 = x4;
    x4 = help;
}

if (x1 < x3 && x2 > x3) {
    Console.WriteLine($"Отрезки пересекаются с {x3} до {x2}");
} else if (x3 < x1 && x4 > x1) {
    Console.WriteLine($"Отрезки пересекаются с {x1} до {x4}");
} else if (x3 == x2) {
    Console.WriteLine ($"Точка пересечения - {x3}");
} else if (x4 == x1){
    Console.WriteLine ($"Точка пересечения - {x4}"); 
} else {
    Console.WriteLine("Не пересекаются");
}
