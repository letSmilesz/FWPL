// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PrintText(string text)
{
    Console.Write(text);
}

dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        int b = Convert.ToInt32(a);
        if (b >= 0 || b < 0) return b;
        else return a;
    }
    else 
    {
        a = "exit";
        return a;
    }
}

int count = 0;
dynamic num = "";
/*PrintText("Сколько чисел вы хотите ввести? ");
int numLength = UserEnterNum();
for (int i = 0; i < numLength; i++)
{
    PrintText($"Введите {i + 1} число: ");
    num = UserEnterNum();
    if (num > 0) count++;
}
*/
PrintText("Вводите числа, пока они не захотите остановиться. В конце программа выдаст, сколько из них было больше 0.");
Console.WriteLine();
for (int i = 1;  num != "exit"; i++)
{
    PrintText($"Введите {i} число: ");
    num = UserEnter();
    if (num is int)
    {
        if (num > 0) count++;
        num = "";
    }
}
PrintText($"Вы ввели {count} числа(-ел) больше 0."); 