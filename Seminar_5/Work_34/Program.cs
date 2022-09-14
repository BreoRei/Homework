// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int count = 0;
for (int index = 0; index < number; index++)
{
    array[index] = new Random().Next(100, 1000);
    Console.Write($"{array[index]} ");
    if (array[index] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {count}");
