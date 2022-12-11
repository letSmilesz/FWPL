Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
string seriesOfNum = "";

while (i <= num)
{
    seriesOfNum = seriesOfNum + i + ", ";
    i++;
}
Console.WriteLine (seriesOfNum);
