// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число номер 1: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число номер 2: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int Max = numA;

// if (Max > numB)
// {
//     Console.WriteLine("Max = " + numA);
//     Console.WriteLine("Min = " + numB);
// }
// else
// {
//     Console.WriteLine("Max = " + numB);
//     Console.WriteLine("Min = " + numA);
// }

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine()
{
    Console.WriteLine();
}

void EndOnPC()
{
    Console.Read();
}


dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        if (int.TryParse(a, out int n))
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        else if (a == "y") return true;
        else if (a == "n") return false;
        else return a;
    }
    else
    {
        a = "exit";
        return a;
    }
}

void PrintArrayMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        NewLine();
    }
    NewLine();
}

int[,] FillMatrixSpiral(int height, int width, int first)
{
    int[,] array = new int[height, width];
    array[0, 0] = first;
    int i = 0, j = 0, circle = 0, action = 0, count = new int();
    if (width >= height) count = height * 2 - 1;
    else count = width * 2;
    while (count != 0)
    {
        if (action == 0)
        {
            j++;
            array[i, j] = array[i, j - 1] + 1;
            if (j == width - 1 - circle)
            {
                action++;
                count--;
            }
        }
        else if (action == 1)
        {
            i++;
            array[i, j] = array[i - 1, j] + 1;
            if (i == height - 1 - circle)
            {
                action++;
                count--;
            }
        }
        else if (action == 2)
        {
            j--;
            array[i, j] = array[i, j + 1] + 1;
            if (j == 0 + circle)
            {
                circle++;
                action++;
                count--;
            }
        }
        else if (action == 3)
        {
            i--;
            array[i, j] = array[i + 1, j] + 1;
            if (i == 0 + circle)
            {
                action = 0;
                count--;
            }
        }
    }
    return array;
}

PrintText("Введите высоту и ширину прямоугольника: ");
NewLine();
int height = UserEnter();
int width = UserEnter();
PrintText("Введите первое число: ");
NewLine();
int first = UserEnter();

int[,] square = FillMatrixSpiral(height, width, first);
PrintArrayMatrix(square);

EndOnPC();

//while (count != 0)
//{
//    while (j < width - 1 - circle)
//    {
//        j++;
//        square[i, j] = square[i, j - 1] + 1;
//    }
//    count--;
//    while (i < height - 1 - circle)
//    {
//        i++;
//        square[i, j] = square[i - 1, j] + 1;
//    }
//    count--;
//    while (j > 0 + circle)
//    {
//        j--;
//        square[i, j] = square[i, j + 1] + 1;
//    }
//    count--;
//    circle++;
//    while (i > 0 + circle)
//    {
//        i--;
//        square[i, j] = square[i + 1, j] + 1;
//    }
//    count--;
//}