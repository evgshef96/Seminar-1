// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Clear();

System.Console.WriteLine("Введите цифру:");
int day = int.Parse(Console.ReadLine()!);

if(day >= 6 && day < 8) 
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}