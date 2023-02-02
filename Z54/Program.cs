// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] getInt2DArray(int colLength, int rowLength, int start, int end)
{
  int [,] array = new int [ colLength,rowLength ];
     for (int i = 0; i < colLength; i++)
     {
         for (int j = 0; j < rowLength; j++)
         {
             array[i,j] = new Random().Next(start, end + 1);  

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
    printColor("\t", ConsoleColor.DarkBlue);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printColor(j + "\t" , ConsoleColor.Blue);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i+"\t", ConsoleColor.Green);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            printColor(array[ i, j] + "\t", ConsoleColor.Gray);
        }
        Console.WriteLine();
    }
}
void MinMaxArray(int [,] array)
{
  int max;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k + 1] > array [i, k] )
        {
          max = array [i, k + 1];
          array [i, k + 1] = array [i, k];
          array [i, k] = max;
        }
      }
    }
  }
}


int [,] array = getInt2DArray(5,5,10,99);
getWriteArray(array);
Console.WriteLine();
printColor("----------Отсортированный массив----------" , ConsoleColor.DarkCyan);
Console.WriteLine();
MinMaxArray(array);
getWriteArray(array);
