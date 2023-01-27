// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 

int GetDataFromUser(string message)
{
    printColor(message + "\n", ConsoleColor.DarkGreen);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
double [,] get2DIntArray(int colLength, int rowLength, int start, int end)
{
    double [,] array = new double [colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array [i,j] = new Random().Next(start,end+1) + Math.Round(new Random().NextDouble(),3);
        }
    }
    return array;
}

void print2DArray(double [,] array)
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
            if(array[i,j]<50)
            {
               printColor(array[ i, j] + "\t", ConsoleColor.Blue);
            }
            else
            {
               printColor(array[ i, j]+"\t", ConsoleColor.Green);
            }
        }
        Console.WriteLine();
    }
}
int n = GetDataFromUser("Введите число строк");
int m = GetDataFromUser("Введите число столбцов");
double [,] array = get2DIntArray(n,m,0,100);
print2DArray(array);