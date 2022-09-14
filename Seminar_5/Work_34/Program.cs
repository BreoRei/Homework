// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Показать массив? Введите 1 если 'да'\nЛюбое другую цифру есть нет: ");
int examination = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int index = 0; index < number; index++)
{
    if (examination == 1)
    {
        array[index] = new Random().Next(100, 1000);
        Console.Write($"{array[index]} ");
    }
    else
    {
        array[index] = new Random().Next(100, 1000);
    }
}
//метод подсчета количество чётных чисел в массиве
void NumberOfEvenNumbers(int[] arr)
{
    int count = 0;
    for (int index = 0; index < number; index++)
    {
        if (arr[index] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел в массиве = {count}");
}


NumberOfEvenNumbers(array);