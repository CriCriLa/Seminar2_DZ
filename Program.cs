// Задача 1. Принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine((num%100)/10);
// ______________________

// Задача 2. Выводит третью цифру заданного числа 
// или сообщает что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num>=100)
{
    string NumStr = Convert.ToString(num);
    Console.WriteLine(NumStr[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}