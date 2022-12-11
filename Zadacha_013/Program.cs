// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:  ");
int count = int.Parse(Console.ReadLine());
int buffer = count;

while (count > 1000)
    count = count / 10;
if (count < 100) 
    Console.WriteLine("В введеном числе нет третьей цифры");
else
{
    int digit3 = count % 10;
    Console.WriteLine($"Третья цифра чилса {buffer} - {digit3}");
}