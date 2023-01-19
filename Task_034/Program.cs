// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// Функция создания массива из рандомных числе
int[] CreateRandomArray(int N, int start, int end)
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
// int N=10, int start=100 b int end=1000 
int [] NewArray = CreateRandomArray(10, 100, 1000);

// Обращаемся к функции ShowArray, 
//чтобы она вывела на экран сгенерированный массив NewArray
ShowArray(NewArray);
Console.Clear();

// Функция, находящая количество чётных чисел в массиве
int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i=0; i< array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

// Обращаемся к функции CountEvenNum, 
// чтобы она нашла количество чётных чисел в массиве NewArray
int countnum = CountEvenNum(NewArray);

// Выводим на экран количество чётных чисел, 
//найденных функцией CountEvenNum в массиве NewArray
Console.WriteLine($"Количество чётных чисел в массиве [ {String.Join(" ,", NewArray)} ] равно: {countnum}");