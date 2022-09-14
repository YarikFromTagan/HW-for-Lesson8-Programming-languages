/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillingSquare(int [,] arr, int numRows, int numColumns)
{
    int startI = 0;
    int startJ = 0;
    int stopI = 0;
    int stopJ = 0;
    int i = 0;
    int j = 0;
    int count = 1;
    
    while (count <= numRows * numColumns)
    {
        arr[i, j] = count;
        if(j == stopJ && i > stopI) i--;
        if(i == numRows - stopI - 1 && j > startJ) j--;
        if(i < numRows - stopI - 1 && j == numColumns - stopJ - 1) i++;
        if(i == startI && j < numColumns - stopJ -1) j++;
        
        if((i == startI +1) && (j == startJ) && (startJ != numColumns - stopJ - 1))
        {
            startI++; startJ++; stopI++; stopJ++;
        }
        count++;
        
    }
    
Print2DArray(arr);
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] <= 9) Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество строк массива n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[n, m];

FillingSquare(array, n, m);

