//  Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 100 && number < 1000)
{
    System.Console.WriteLine($"Вторая цифра числа: " + $"{number /10 % 10}");
}
else
{
  System.Console.WriteLine("Введите трёхзначное число!");  
}

