// Задача.19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = num;
int polydrome = 0;

while (num != 0)
{
    polydrome = polydrome * 10 + (num % 10);
    num /= 10;
}
if (numbers == polydrome)
{
    Console.WriteLine($"{numbers} является палиндромом");
}
else
    Console.WriteLine($"{numbers} не является палиндромом");
