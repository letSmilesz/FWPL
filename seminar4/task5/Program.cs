//Вводится число, потом запрашивается столько чисел, чему равно число. Нужно найти среди введенных самое большое и 
//второе по величине

Console.Write("Введите число: ");
int length = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;

// for (int i = 0; i < length; i++){
//     Console.Write($"Введите {i+1} число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number > max){
//         max2 = max;
//         max = number;
//     }
// }

// Console.WriteLine($"{max} - самое большое число, {max2} - второе по величине");

int [] numbers = new int [length];
string answer = "Из массива ";
for (int i = 0; i <numbers.Length; i++){
    Console.Write($"Введите {i+1} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    answer += ($"{numbers[i]}, ");
}

for (int i = 0; i <numbers.Length; i++){
    if (numbers[i]>max){
        max2 = max;
        max = numbers[i];
    }
}
answer += ($"самое большое число - {max}, второе по величине - {max2}");
Console.WriteLine(answer);
