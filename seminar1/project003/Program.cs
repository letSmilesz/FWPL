Console.WriteLine ("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

string dayOfWeek = ("день недели");
if (num == 1)
{
    dayOfWeek = ("Понедельник");
}
if (num == 2)
{
    dayOfWeek = ("Вторник");
}
if (num == 3)
{
    dayOfWeek = ("Среда");
}
if (num == 4)
{
    dayOfWeek = ("Четверг");
}
if (num == 5)
{
    dayOfWeek = ("Пятница");
}
if (num == 6)
{
    dayOfWeek = ("Суббота");
}
if (num == 7)
{
    dayOfWeek = ("Воскресенье");
}

Console.WriteLine (dayOfWeek);