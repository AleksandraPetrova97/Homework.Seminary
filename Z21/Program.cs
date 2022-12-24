//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double getDistanceCoordinate(int userAX, int userAY, int userBX, int userBY, int userСX, int userСY)
{
    double result = Math.Sqrt(Math.Pow((userAX-userBX-userСX),2)+ Math.Pow((userAY-userBY-userСY),2));
    return result;
}

int userAX =  getUserValue("Введите AX");
int userAY =  getUserValue("Введите AY");
int userBX =  getUserValue("Введите BX");
int userBY =  getUserValue("Введите BY");
int userСX =  getUserValue("Введите СX");
int userСY =  getUserValue("Введите СY");

double distance = getDistanceCoordinate( userAX,  userAY,  userBX, userBY, userСX, userСY);
Console.WriteLine($"Расстояние между точками {distance}");
