// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16


int getUserNumber(string message)
{
    Console.WriteLine(message);
    int UserNumber = int.Parse(Console.ReadLine()!);
    return UserNumber;
}

int getdegreeOfRange(int numA, int numB)
{
    int degree = numA;
    for (int i = 1; i < numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
} 

int numA = getUserNumber("Введите число А");
int numB = getUserNumber("Введите число B");
int degree = getdegreeOfRange(numA, numB);
Console.Write($"Число А в степени числа Б = {degree}");
