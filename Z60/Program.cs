// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

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
int [,,] get3array (int colLeght, int rowLeght, int letLeght)
{
   int [,,] array = new int[colLeght, rowLeght, letLeght];
   return array;
}
void print3DArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k]>50)
                {
                    printColor( $"{array[i,j,k]} ({i},{j},{k}) " , ConsoleColor.DarkGreen);    
                }
                else
                {
                    printColor( $"{array[i,j,k]} ({i},{j},{k}) " , ConsoleColor.Yellow);
                }
            }
            Console.WriteLine();
        }        
    }
}
void getArrayNew(int [,,] array)
{
    int [] arr = new int [array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int uniqul;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(10, 99);
        uniqul = arr[i];
        if(i>=1)
        {
            for (int j = 0; j < i; j++)
            {
               while(arr[i]==arr[j])
               {
                arr[i] = new Random().Next(10,99);
                j = 0;
                uniqul = arr[i];
               }
            uniqul = arr[i];
            }
        }
    }
  int sum = 0; 
  for (int n = 0; n < array.GetLength(0); n++)
  {
    for (int m = 0; m < array.GetLength(1); m++)
    {
      for (int p = 0; p < array.GetLength(2); p++)
      {
        array[n, m, p] = arr[sum];
        sum++;
      }
    }
  }
}
int n = GetDataFromUser("Введите размер массива");
int m = GetDataFromUser("Введите размер массива");
int p = GetDataFromUser("Введите размер массива");
int [,,] array = get3array(n,m,p);
getArrayNew(array);
print3DArray(array);

