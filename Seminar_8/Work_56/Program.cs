// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int TheRowWithTheSmallestSum(int[,] arr)
{
    int min = 0;
    int sumFirst = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumSecond = 0;
        if (i == 0)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sumFirst += arr[i, j];
            }
        }
        else
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sumSecond += arr[i, j];
            }
            if (sumFirst > sumSecond)
            {
                min = i;
                sumFirst = sumSecond;
            }
        }
    }
    return min;
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
PrintTextToString($"Нименьшая сумма элементов:{TheRowWithTheSmallestSum(array) + 1} строка");
