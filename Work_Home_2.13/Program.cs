// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (int.Parse (number) > 99)
{
    Console.WriteLine("Третья цифра числа: " + number[2]);
}
else
{
   Console.WriteLine("Третьей цифры нет"); 
}
