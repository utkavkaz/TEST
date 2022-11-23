//Напишите программу, которая принимает на вход целое число любой разрядности 
//и на выходе показывает третью цифру слева этого числа или говорит, 
//что такой цифры нет.

Console.WriteLine("Введите целое положительное число");

int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 < 100)
{
   Console.WriteLine("такой цифры нет"); 
}
else
{
   int a = 10;
   
   while (num1 > 1000)
   {
    int num2 = num1/a;
    a=a*10;
   }
   
   int num3 = num1%10;
   
   Console.WriteLine($"{num3}");
}

