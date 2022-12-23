//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру дня недели");
int number = int.Parse(Console.ReadLine()!);

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5 )
{
    Console.WriteLine($"{number} - нет");
}
else if (number == 6 || number == 7 )
{
    Console.WriteLine($"{number} - да");
}
else
{
    Console.WriteLine("Введите другое число");
}

