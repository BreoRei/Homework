// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintTextWithLineBreak(String text)
{
    Console.WriteLine(text);
}

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

int[,] MatrixProduct(int[,] arr, int[,] arrA)
{
    int[,] arrB = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                arrB[i, j] += arr[i, k] * arrA[k, j];
            }
        }
    }
    return arrB;
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

Console.Clear();
int line = 2;
int column = 2;
PrintTextToString("Введите начальное значение диапазона для массива: ");
int first = UserInput();
PrintTextToString("Введите конечное значение диапазона для массива: ");
int second = UserInput();
Console.Clear();
int[,] matrixFirst = FillingAnArray(line, column, first, second);
PrintArray(matrixFirst);
PrintTextWithLineBreak(string.Empty);
int[,] matrixSecond = FillingAnArray(column, line, first, second);
PrintArray(matrixSecond);
PrintTextWithLineBreak(string.Empty);
int[,] matrixThird = MatrixProduct(matrixFirst, matrixSecond);
PrintArray(matrixThird);



