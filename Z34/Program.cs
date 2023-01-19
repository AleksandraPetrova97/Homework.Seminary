// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

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

int FindSumNumber(int [] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]%2==0)
       {
        num = num + 1;
       } 
    }
    return num;
}

int number = getUserData("Введите количество элементов массива");
int [] array = Fillarray(number, 100, 999);
int Sumnum = FindSumNumber(array);

void printArray(int[] array)
{
    Console.Write($"В массиве [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]},");
        }
        else
        {
        Console.WriteLine($"{array[i]}] - {Sumnum} чётных чисел");
        }
    }
}

printArray(array);

