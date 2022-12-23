// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int  number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine(max);

