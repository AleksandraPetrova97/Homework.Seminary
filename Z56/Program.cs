// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
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
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int [] SumLine(int [,] array)
{
    int [] result = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        result [i] = 0;    
        for (int j = 0; j < array.GetLength(1); j++) 
       {
        result [i] = result [i] + array[i,j];
       }
        Console.Write($"{result [i]}-;");        
    }
    return result;
}
int MinLine(int [] array)
{
    int MinLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        if(array[i] < array[MinLine]) 
        {
            MinLine=i;
        }
        Console.WriteLine();
    return MinLine;    
}

int [,] array = get2DIntArray(10,4,0,99);
print2DArray(array);
int [] Min = SumLine(array);
int Line = MinLine(Min);
Console.WriteLine($"В {Line} строке меньшая сумма элементов");


 


