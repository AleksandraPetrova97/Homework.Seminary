//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27, 5 -> 1, 8, 27, 64, 125

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int N =  getUserValue("Введите число");

for (int i = 1; i<=N; i++)
{
    if (i<N)
    {Console.Write(Math.Pow(i,3) + ", " );}
    else
    {Console.Write(Math.Pow(i,3) + ". " );}
}
