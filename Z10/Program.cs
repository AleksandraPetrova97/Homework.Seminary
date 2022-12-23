
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

int ShowSecondDigit(int num)
{
    int digit2 = num / 10 % 10;
    return digit2;
}
int digit2 = ShowSecondDigit(num);
Console.WriteLine($"{num} - {digit2}");