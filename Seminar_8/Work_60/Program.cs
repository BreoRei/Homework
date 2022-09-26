// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int m, int n, int p)
{
    int[,,] arr = new int[m, n, p];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (0 == count)
                {
                    Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                    count = 1;
                }
                else
                {
                    Console.WriteLine($"{arr[i, j, k]}({i},{j},{k})");
                    count = 0;
                }
            }
        }
    }
}

Console.Clear();
int line = 2;
int column = 2;
int depth = 2;
Console.Clear();
int[,,] array = FillArray(line, column, depth);
PrintArray(array);












