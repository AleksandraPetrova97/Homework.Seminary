// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

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
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}


int DifferenceNumber(int [] array)
{
    int min = array[0];
    int max = array[0];
    int difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
    
        } else if (array[i] > max)
        {
            max = array[i];
        }
        difference = max - min;
    }
    return difference;
}    

int number = getUserData("Введите количество элементов массива");
int [] array = Fillarray(number, 1, 99);
int difference = DifferenceNumber(array);

void printArray(int[] array)
{
    Console.Write($" Разница между максимальным и минимальным элементов массива [ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]} ");
        }
        else
        {
        Console.WriteLine($"{array[i]} ] - {difference}. ");
        }
    }
}


printArray(array);

