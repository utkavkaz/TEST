//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num <= 7)
{
    if (num == 1)
    { 
    Console.WriteLine("понедельник");
    }

    if (num == 2)
    {
        Console.WriteLine("вторник");
    }

    if (num == 3)
    {
        Console.WriteLine("среда");
    }

    if (num == 4)
    {
        Console.WriteLine("четверг");
    }
    
    if (num == 5)
    {
        Console.WriteLine("пятница");
    }

    if (num == 6)
    {
        Console.WriteLine("субота");
    }

    if (num == 7)
    {
        Console.WriteLine("воскрксенье");
    }
}
else
{
    Console.WriteLine("вы ввели неверное число");
}