//функции для сортировки массива по возрастанию и по убыванию(метод вставками)

Console.Clear();
int [] numbers = { 4, 6, 1, 7, 8, 3 ,6, 7, 9, 2, 3, 5, 1};

void printArray(int [] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void sortToMax (int [] array){
    for (int i = 0; i < array.Length-1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex]) minIndex = j;
        }
        int help = array[i];
        array[i] = array[minIndex];
        array[minIndex] = help;
    }
}

void sortToMin (int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        int maxIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > array[maxIndex]) maxIndex = j;
        }
        int help = array[i];
        array[i] = array[maxIndex];
        array[maxIndex] = help;
    }
}

printArray(numbers);
sortToMax(numbers);
printArray(numbers);
sortToMin(numbers);
printArray(numbers);
