// Задача.19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int help = numbers;
string revers = "";

while (help > 0)
{
    int x = help % 10;
    help /= 10;
    revers += x;
    int х = 0;
}
int numbers_two = Int32.Parse(revers);
if (numbers == numbers_two)
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}