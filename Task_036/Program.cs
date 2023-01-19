// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


// Функция, генерирующая массив
int [] CreateRandomArray(int N, int start, int end)
{
    int [] RandomArray = new int[N];
    for(int i =0; i<N; i++)
    {
    RandomArray[i] = new Random().Next(start, end - 1);
    }
    return RandomArray;
}

// Функция вывод существующего массива на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Обращение к функции CreateRandomArray, 
//чтобы она сгенерировала массив NewArray с параметрами
// int N=6, int start=-100 и int end=100 
int [] NewArray = CreateRandomArray(5, -100, 100);


ShowArray(NewArray);
Console.Clear();


// Функция, находящая сумму чисел с нечётными индексами
int SummaNumberOddIndex (int[] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}


// Обращение к функции SummaNumberOddIndex, 
//чтобы она посчитала сумму чисел с начётными 
//индексами из массива NewArray 
int sumnumoddindex = SummaNumberOddIndex (NewArray);


Console.Write("Сумма чисел с нечётными индексами из массива:");
ShowArray(NewArray);
Console.Write("равна:");
Console.Write(sumnumoddindex);