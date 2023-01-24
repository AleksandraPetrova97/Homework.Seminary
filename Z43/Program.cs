// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double getUserData(string message)
{
    Console.WriteLine(message);
    double UserData = Convert.ToDouble(Console.ReadLine());
    return UserData;
}

var k1 = getUserData("Введите k1: ");
var b1 = getUserData("Введите b1: "); 
var k2 = getUserData("Введите k2: "); 
var b2 = getUserData("Введите b2: "); 



var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");