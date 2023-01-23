// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32 (Console.ReadLine ());

int secondnamber = (( a / 10 ) % 10 );

Console.WriteLine ("{0} Вторая цифра трехзначного чиcла ", secondnamber);
