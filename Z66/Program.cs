// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getSumRange(int numberM, int numberN)
{
    if(numberM == numberN)
    {
        return numberM;
    }
    else
    {
       return numberM +  getSumRange(numberM + 1, numberN);
    }
}

int numberM = getDataFromUser("Введите число M");
int numberN = getDataFromUser("Введите число N");
int sum = getSumRange(numberM, numberN);
Console.WriteLine(sum);