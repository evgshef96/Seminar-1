// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Clear();

System.Console.WriteLine("Введите число:");
int number = new Random().Next(100,1000);
System.Console.WriteLine("Число: " + number);

int quotient = number / 10;
int remainder = quotient % 10;
System.Console.Write("Вторая цифра: " + remainder);
