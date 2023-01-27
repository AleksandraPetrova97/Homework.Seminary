// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string ArithmeticMean(int [,] array)
{
    string Arithmetic = string.Empty;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        { 
            result = result + array[i,j];
        }
        result = result /   array.GetLength(0);
        Arithmetic = ($"{Arithmetic} {result};");

    }
    return Arithmetic;
}

    int n = GetDataFromUser("Введите число строк");
    int m = GetDataFromUser("Введите число столбцов");
    int [,] array = get2DIntArray(n,m,0,10);
    print2DArray(array);
    string Arithmetic = ArithmeticMean(array);
    Console.Write($" Среднее арифметическое каждого столбца {Arithmetic} ");







