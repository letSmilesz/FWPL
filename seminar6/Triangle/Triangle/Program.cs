//Создать программу которая длинам сторон треугольника определит, может ли он существовать
void PrintText(string text)
{
    Console.Write(text);
}

int UserEnterNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int[] num = new int[3]; 
for (int i = 0; i < num.Length; i++)
{
    PrintText($"Введите {i + 1} число: ");
    num[i] = UserEnterNum();    
}
if (num[0] < num[1] + num[2] && num[1] < num[0] + num[2] && num[2] < num[0] + num[1])
    PrintText("Такой треугольник может существовать");
else PrintText("Такой треугольник не может существовать");