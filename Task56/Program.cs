/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Created2DArray()
{
    Console.Write("Введите количество строк создаваемого массива m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов создаваемого массива n = ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное значение массива min = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение массива max = ");
    int max = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    int[,] arr = new int[m, n];
    for( int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindSumRow(int[,] arr)
{
    int[] sumRows = new int[arr.GetLength(0)];
    int min = sumRows[0];
    
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                sumRows[i] += arr[i, j];
            }
        }
    return sumRows;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    Console.WriteLine();
}

int FindMin(int[] arr)
{
    int count = 0;
    int min = arr[0];

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            count = i;
            min = arr[i];
        }
    }
    return count;

}

Console.Clear();
int[,] array = Created2DArray();

Print2DArray(array);

int[] sumRows = FindSumRow(array);

PrintArray(sumRows);

Console.WriteLine($"Номер строки с минимальной суммой элементов - {FindMin(sumRows) + 1} ");
Console.WriteLine();


