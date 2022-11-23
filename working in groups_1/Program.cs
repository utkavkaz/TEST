//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли 
//первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ворое число");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine("первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("первое число не является квадратом второго числа");
}