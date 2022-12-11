// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A.");
Console.Write("Введите координату по оси X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B.");
Console.Write("Введите координату по оси X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

//c^2 = a^2 + b^2
double distAB = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
distAB = Math.Round(distAB, 2);
Console.WriteLine(distAB);