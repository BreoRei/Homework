// Задача 15: Напишите программу, которая принимает на вход цифру, 
//            обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.Write("Введите номер дня недели (1,2,3,4,5,6,7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (1 <= day && day <= 5)
{
    Console.WriteLine("Будни");
}
else if (6 == day || 7 == day)
{
    Console.WriteLine("Ура выходной");
}
else
    Console.WriteLine("Номер не являеться днем недели");