// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int [] Fillarray (int length, int start, int end)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine());
    return UserData;
}

int FindSumElements(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (i%2==0)
       {
        sum = sum + 0;
       } 
       else
       {
        sum = sum + array[i];
       }
    }
    return sum;
}

int number = getUserData("Введите количество элементов массива");
int [] array = Fillarray(number, 100, 999);
int sum = FindSumElements(array);

void printArray(int[] array)
{
    Console.Write($" Сумма нечётных элементов в массиве [ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]}, ");
        }
        else
        {
        Console.WriteLine($"{array[i]} ] - {sum}. ");
        }
    }
}


printArray(array);
