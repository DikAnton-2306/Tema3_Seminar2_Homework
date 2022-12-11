// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру дня недели:  ");
int digit = int.Parse(Console.ReadLine());

if (digit > 0 && digit < 8)
{
    if (digit == 6 || digit == 7)
        Console.WriteLine($"{digit}-й - это выходной!");
    else
        Console.WriteLine($"{digit}-й - это НЕ выходной...");
}
else
    Console.WriteLine($"{digit}-й - это вообще НЕ день недели.");