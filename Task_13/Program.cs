// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Clear();

System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Число:" + number);

if(number >= 100)
{
    while(number>=1000)
    {
        int quotient = number / 10;
        number = quotient + 0; 
    }
    int remainder = number % 10;
    System.Console.WriteLine("Третья цифра: " + remainder);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
