//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();


Console.WriteLine("введите M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void PrintSum(int m, int n, int sum)
 {
     sum = sum + m;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m + 1, n , sum);

 }
 Console.Write($"Сумма чисел от {m} до {n} = ");
 PrintSum(m, n, sum);
