// Задача 1. Принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((num%100)/10);