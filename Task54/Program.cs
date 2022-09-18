/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//89286277515 Никита gtx 1050 ti

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

int[,] ChangeArray(int[,] arr)
{
    for(int k = 0; k < arr.GetLength(0); k++)
    {
        for(int i = 0; i < arr.GetLength(1) - 1; i++)
        {
            for(int j = i + 1; j < arr.GetLength(1); j++)
            {
                if(arr[k, j] > arr[k, i])
                {
                    int count = arr[k, i];
                    arr[k, i] = arr[k, j];
                    arr[k, j] = count;
                }
            }
        }
    }
    return arr;
}

Console.Clear();

int[,] array = Created2DArray();

Print2DArray(array);

int[,] newArray = ChangeArray(array);

Print2DArray(newArray);




