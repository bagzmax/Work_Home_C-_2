//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


Console.Write("Введите номер дня недели: ");
int day = int.Parse (Console.ReadLine ()!);

if (day == 6 || day == 7)
{
System.Console.WriteLine("Да, это выходной");
}
else 
{
Console.WriteLine("Нет, это не выходной");
}

