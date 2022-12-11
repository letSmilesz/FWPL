// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void PrintText(string text)
{
    Console.Write(text);
}

double UserEnterNum()
{
    double a = Convert.ToDouble(Console.ReadLine());
    return a;
}

PrintText("Введите b1: "); //длина отрезка от начала координат(где она пересекается с y
double b1 = UserEnterNum();
PrintText("Введите k1: ");//угол наклона прямой от y в сторону x(положительно)
double k1 = UserEnterNum();
PrintText("Введите b2: ");
double b2 = UserEnterNum();
PrintText("Введите k2: ");
double k2 = UserEnterNum();
//если угол совпадает, но высота по y разная, то прямые параллельны
if (k1 == k2 && b1 != b2) PrintText("Прямые параллельны, точки пересечения нет");
//если угол и высота совпадают, то прямые тоже совпадают
else if (k1 == k2 && b1 == b2) PrintText("Прямые совпадают, точек пересечения бесконечное множество");
//во всех остальных случаях прямые имеют одну точку пересечения
else 
{
    double x = (b1 - b2) / -(k1 - k2);
    double y = k1 * x + b1;
    PrintText($"Точка пересечения: \nx = {x}\ny = {y}");
}


