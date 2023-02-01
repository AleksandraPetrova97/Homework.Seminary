//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int GetDataFromUser(string message)
{
    printColor(message + "\n" , ConsoleColor.DarkBlue);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void printColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int [,] getIntMatrix(int colLength, int rowLength, int start, int end)
{
    int [,] matrix = new int [colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
         for (int j = 0; j < rowLength; j++)
        {
            matrix [i,j] = new Random().Next(start,end+1);
        }
    }
    return matrix;
}
void printMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[ i, j] + " " );
        }  
        Console.WriteLine();  
    }
}
int n = GetDataFromUser("Введите количество строк в матрицах");
int m = GetDataFromUser("Введите количество столбцов в матрицах");
int [,] matrix = getIntMatrix(n,m,1,9);
int [,] matrix2 = getIntMatrix(n,m,1,9);
printColor($"Первая матрица" + "\n", ConsoleColor.DarkMagenta);
printMatrix(matrix);
printColor($"Вторая матрица" + "\n", ConsoleColor.DarkYellow);
printMatrix(matrix2);

int [,] getIntProdactionMatrix(int [,] matrix, int [,] matrix2)
{
    int [,] ProdactionMatrix = new int [n,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++ )
        {
            int Prodaction = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                Prodaction += matrix[i,k] * matrix2[k,j];
            }
            ProdactionMatrix[i,j] = Prodaction;
        }
        
    }
    return ProdactionMatrix;
}

    int [,] ProdactionMatrix = getIntProdactionMatrix(matrix,matrix2);
    printColor($"Результативная матрица" + "\n", ConsoleColor.DarkGreen);
    printMatrix(ProdactionMatrix);


