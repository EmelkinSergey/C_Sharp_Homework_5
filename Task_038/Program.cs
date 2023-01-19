// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.


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

int[] NewArray = CreateRandomArray(10, 1, 100);
ShowArray(NewArray);
Console.Clear();

// Функция находжения максимального числа из массива
int MaxNum (int[] maxarray)
{
    int maxnum = maxarray[0];
    for(int i = 0; i<maxarray.Length; i++)
    {
        if (maxarray[i]>maxnum)
        {
            maxnum = maxarray[i];
        }
    }
    return maxnum;
}

// Функция находжения минимального числа из массива
int MinNum (int[] minarray)
{
    int minnum = minarray[0];
    for(int i = 0; i<minarray.Length; i++)
    {
        if (minarray[i]<minnum)
        {
            minnum = minarray[i];
        }
    }
    return minnum;
}


int max = MaxNum(NewArray);
int min = MinNum(NewArray);

int result = max - min;

Console.WriteLine("Разница между максимальным и манимальным элементом из массива:");
ShowArray(NewArray);
Console.Write("равна:");
Console.Write(result);