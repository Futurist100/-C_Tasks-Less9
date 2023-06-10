// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число: M ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число: N");
int N = Convert.ToInt32(Console.ReadLine());



int sum = 0;

void RoadToN(int M)

{ 

if (M == N+1)

{
System.Console.Write($"{sum} ");
return;
}
sum = sum + M;

RoadToN(M + 1);

}



RoadToN(M);

