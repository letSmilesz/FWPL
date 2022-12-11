void insertionSort (int [] arr, int n){
    int i, j;
    for (i = 1; i < n; i++){
        j = i;
        while ((j > 0) && (arr[j] < arr[j-1])){
            int help = arr[j];
            arr[j] = arr[j-1];
            arr[j-1] = help;
            j--;
        }
    }
}

Console.Clear();
int [] numbers = new int [10];
for (int i = 0; i < numbers.Length; i++){
    numbers[i] = new Random().Next(0, 100);
}
for (int i = 0; i < numbers.Length; i++){
    Console.Write(numbers[i] + ", ");
}

insertionSort(numbers, numbers.Length);
Console.WriteLine();
for (int i = 0; i < numbers.Length; i++){
    Console.Write(numbers[i] + ", ");
}