// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine ());

System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine ());

System.Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32 (Console.ReadLine ());

if (a > b && a > c)
{
     Console.WriteLine("{0} max ", a);
}

else if (b > a && a > c)
{
    Console.WriteLine("{0} max ", b);
}

else if (c > a && c > b)
{
    Console.WriteLine("{0} max ", c);
}

