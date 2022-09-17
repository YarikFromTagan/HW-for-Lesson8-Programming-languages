/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] CreatedArray(int size)
{
    int[] arr = new int[size];
    for(int i = 10; i < size + 10; i++)
    {
        arr[i-10] = i;
    }
    //PrintArray(arr);
    return arr;
}

int[,,] Created3DArray()
{
    Console.WriteLine("Для создаваемого трёхмерного массива");
    Console.Write("Введите количество строк  координате х = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк по координате у = ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк по координате z = ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int sizeArray = x * y * z;
    int[] array = CreatedArray(sizeArray);
    int[,,] arr = new int[x, y, z];
    int n = 0;

    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                arr[i, j, k] = array[n];
                n++;
            }
        }
    }
    return arr;
}

void Print3DArray(int[,,] arr)
{
    for(int k = 0; k < arr.GetLength(2); k++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Clear();
int[,,] Array3D = Created3DArray();

Print3DArray(Array3D);



