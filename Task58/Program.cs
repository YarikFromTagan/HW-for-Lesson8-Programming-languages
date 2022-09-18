/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] Created2DArray()
{
    Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение элемента min = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение элемента max = ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();

    int[,] arr = new int[n, m];

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
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
            if(arr[i, j] < 10) Console.Write($"0{arr[i, j]} ");
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixAxB(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLongLength(1)];
    for(int i = 0; i < arrA.GetLength(0); i++)
    {
        for(int j = 0; j < arrB.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < arrB.GetLength(0); k++)
            {
                sum += arrA[i, k] * arrB[k, j];
            }
            arrC[i, j] = sum;
        }
    }
    return arrC;
}

Console.Clear();
Console.WriteLine("* Не забываем, что количество строк матрицы В должно быть равно количеству столбцов матрицы А");
Console.WriteLine();

Console.WriteLine("Для матрицы А");
int[,] arrayA = Created2DArray();

Console.WriteLine("Для матрицы В");
int[,] arrayB = Created2DArray();

Console.WriteLine("   A");
Print2DArray(arrayA);
Console.WriteLine("   B");
Print2DArray(arrayB);

int[,] arrayC = MatrixAxB(arrayA, arrayB);
Console.WriteLine("  AxB");
Print2DArray(arrayC);








