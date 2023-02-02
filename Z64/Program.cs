// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
void printRange(int N)
{
    if(N == 0)
    {
        return;
    }
    Console.Write(N + ",");
    printRange(N-1);
}

int N = getDataFromUser("Введите число N");
printRange(N);



