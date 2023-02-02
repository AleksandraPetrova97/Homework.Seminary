// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] getIntArray(int colLength, int rowLength)
{
    int [,] array = new int [colLength, rowLength];
    int res = 1;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = res;
            res = res + 1;
        }
    }
    res = 5;
    for (int j = 3; j < rowLength; j++)
    {
        for (int i = 1; i < colLength; i++)
        {
            array[i,j] = res;
            res = res + 1;
        }
        
    }
    res = 10;
    for (int i = 3; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = res;
            res = res - 1;
        }
    }
    res = 12;
    for (int j = 0; j < 1; j++)
    {
        for (int i = 1; i <= 2; i++)
        {
            array[i,j] = res;
            res = res - 1;
        }
    }
    res = 13;
    for (int i = 1; i < 2; i++)
    {
         for (int j = 1; j <= 2; j++)
         {
            array[i,j] = res;
            res = res + 1;
         }   
    }
    res = 16;
    for (int i = 2; i < 3; i++)
    {
        for (int j = 1; j <= 2; j++)
        {
            array[i,j] = res;
            res = res - 1;
        }
    }


    return array;
}

void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void getWriteArray(int [,] array)
{
    Console.Write("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkMagenta);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[ i, j] + "\t" );
        }
        Console.WriteLine();
    }
}

 

int [,] array = getIntArray(4,4);
getWriteArray(array);
