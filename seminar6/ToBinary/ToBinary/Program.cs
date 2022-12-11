//Написать программу перевода числа в двоичную систему

void PrintText(string text)
{
    Console.Write(text);
}

int UserEnterNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}


void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int help = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = help;
    }
}

void ToBinary (int [] arr, int n)
{
    for (int i = 0; n > 0; i++)
    {
        arr[i] = n % 2;
        n /= 2;
    }
    ReverseArray(arr);
}

PrintText("Введите число: ");
int num = UserEnterNum();
int[] number = new int[8];//8 бит
ToBinary(number, num);
PrintArray(number);