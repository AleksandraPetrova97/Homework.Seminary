// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12

int getUserNumber(string message)
{
    Console.WriteLine(message);
    int UserNumber = int.Parse(Console.ReadLine()!);
    return UserNumber;
}


int getSumOfDigit(int number)
{
    int SumOfDigit = 0;
    while(number > 0)
    {
       SumOfDigit = SumOfDigit + number % 10;
       number = number / 10;
    }
    return SumOfDigit;
   
}

int number = getUserNumber("Введите число");
int SumOfDigit = getSumOfDigit(number);
Console.Write($"сумма цифр в числе {number} = {SumOfDigit}");