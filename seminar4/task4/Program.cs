int [] numbers = new int [8];

for (int i = 0; i < numbers.Length; i++){
    numbers[i] = new Random().Next(0,2);
    Console.Write (numbers[i]);
}