// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Sidney(int number)
{
  int result = 1;
  for (int i = 1; i <= number; i++)
  {
    result = result * i;
  }
return result;
}

int Pront(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(System.Console.ReadLine());
  return result;
}

int hot = Pront("Введите число: ");
System.Console.Write(Sidney(hot));