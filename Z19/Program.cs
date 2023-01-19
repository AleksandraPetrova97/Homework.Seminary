//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да
int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int num =  getUserValue("Введите число");

if (num/10000 == num%10 && num/1000%10 == num/10%10)
{
    Console.WriteLine($"{num} - да" );
}
else 
{
    Console.WriteLine($"{num} - нет" );
}
