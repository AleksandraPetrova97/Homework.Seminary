// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int getDataFromUser(string message)
{
    Console.WriteLine(message);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int Ack(int numberM, int numberN)
{
  if (numberM == 0)
  {
    return numberN + 1;
  } 
  if (numberM > 0 && numberN == 0)
  {
    return Ack(numberM - 1, 1);
  }
  else
  {
    return Ack(numberM - 1, Ack(numberM, numberN - 1));
  }  
}

int numberM = getDataFromUser("Введите число М");
int numberN = getDataFromUser("Введите число N");
int AkkermanFunction = Ack(numberM, numberN);
Console.Write($"Функция Аккермана = {AkkermanFunction} ");



