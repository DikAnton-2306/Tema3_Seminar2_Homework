// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int count = int.Parse(Console.ReadLine());

if ((count > 99) && (count < 1000)) 
{
    int count2 = (count / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {count} - {count2}");
}
else Console.WriteLine("Это неподходящее число");