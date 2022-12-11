//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

string exit = "";
while (exit != "n"){
    Console.WriteLine("Введите координаты точки A.");
    Console.Write("Введите координату по оси X: ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату по оси Y: ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату по оси Z: ");
    int za = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B.");
    Console.Write("Введите координату по оси X: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату по оси Y: ");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату по оси Z: ");
    int zb = Convert.ToInt32(Console.ReadLine());


    //c^2 = a^2 + b^2
    double distAB = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
    distAB = Math.Round(distAB, 2);
    Console.WriteLine(distAB);
    Console.WriteLine("Хотите ввести ещё одну пару точек? y/n");
    exit = Console.ReadLine();
}