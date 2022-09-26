// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int[,] FillingAnArray(int m, int n, int mix, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(mix, max);
        }
    }
    return arr;
}

int[,] StringSorting(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = arr[i, j];
            for (int g = j + 1; g < arr.GetLength(1); g++)
            {
                if (arr[i, g] > max)
                {
                    max = arr[i, g];
                    int temporary = arr[i, j];
                    arr[i, j] = arr[i, g];
                    arr[i, g] = temporary;
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintTextToString("Введите количество строк: ");
int line = UserInput();
PrintTextToString("Введите количество столбцов: ");
int column = UserInput();
PrintTextToString("Введите начальное значение массива: ");
int first = UserInput();
PrintTextToString("Введите конечное значение массива: ");
int second = UserInput();
Console.Clear();
int[,] array = FillingAnArray(line, column, first, second);
PrintArray(array);
Console.WriteLine();
PrintArray(StringSorting(array));