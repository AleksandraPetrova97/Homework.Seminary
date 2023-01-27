// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int GetDataFromUser(string message)
{
    printColor(message + "\n", ConsoleColor.DarkBlue);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int [,] get2DIntArray(int colLength, int rowLength, int start, int end)
{
    int [,] array = new int [colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array [i,j] = new Random().Next(start,end+1);
        }
    }
    return array;
}

void print2DArray(int [,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t" , ConsoleColor.Yellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i+"\t", ConsoleColor.Red);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            printColor(array[ i, j] + "\t", ConsoleColor.Magenta);
        }
        Console.WriteLine();
    }
}


int FindNUmber(int n, int m, int i, int j, int [,] array)
{
    if(i>n && j>m)
    {
        Console.WriteLine($"Такого числа нет");
    }
    else
    {
        Console.WriteLine($"Число на позициях {i} и {j} в массиве = {array[i,j]}");
    }
    return array[i,j];
}

int n = GetDataFromUser("Введите число строк");
int m = GetDataFromUser("Введите число столбцов");
int i = GetDataFromUser("Введите позицию i");
int j = GetDataFromUser("Введите позицию j");
int [,] array = get2DIntArray(n,m,0,100);
print2DArray(array);
int Find = FindNUmber(n,m,i,j,array);













