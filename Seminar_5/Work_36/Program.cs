// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите длинну массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон чисел в  массиве:\nПервая величина -> ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая величина -> ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int index = 0; index < number; index++)
{
    array[index] = new Random().Next(numA, numB);
    Console.Write($"{array[index]} ");
}

//метод суммы чисел с нечетными индексами
void SumOfEvenElements(int[] arr)
{
    int sum = 0;

    for (int index = 0; index < number; index++)
    {

        if (index % 2 != 0)
        {
            sum += arr[index];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма нечетных позиций = {sum}");
}

SumOfEvenElements(array);