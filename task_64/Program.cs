// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.Write("Введите число: ");

int temp = Convert.ToInt32(Console.ReadLine());

int number=1;

void RoadToN(int number)
{
if (number == temp+1)
{
return;
}
RoadToN(number + 1);

System.Console.Write($"{number} ");

}


RoadToN(number);


