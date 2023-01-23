// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.Write("Является ли этот день выходным? Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine ());

switch (a)
{
case 1:
System.Console.WriteLine("НЕТ");
break;

case 2:
System.Console.WriteLine("НЕТ");
break;

case 3:
System.Console.WriteLine("НЕТ");
break;

case 4:
System.Console.WriteLine("НЕТ");
break;

case 5:
System.Console.WriteLine("НЕТ");
break;

case 6:
System.Console.WriteLine("ДА");
break;

case 7:
System.Console.WriteLine("ДА");
break;

default:
System.Console.WriteLine("Введите число от 1 до 7");
break;
}

