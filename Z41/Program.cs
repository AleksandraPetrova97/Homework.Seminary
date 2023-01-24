// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2  
int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
string Numbernum(int number)
{
    int i = 0;
    int sum = 0;
    String result = string.Empty;
    while(i<number)
    {
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
        {
            sum=sum+1;
        }
        i++;
        if (i<number)
        {
            result = ($"{result} {num} ,");
        }
        else 
        {
            result = ($"{result} {num} ");
        }      
    } 
    result = ($"{result} = {sum}");
    return result;
}

int number = getUserData("Введите число М");
string res = Numbernum(number);
Console.WriteLine($"{res}");

