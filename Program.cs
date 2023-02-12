


//--------------Домашняя работа-------------

// Задача 64: Выполнить с помощью рекурсии.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Натуральные числа от {N} до 1: {PrintNumbers(N,1)}");

// //-------метод----------

// string PrintNumbers(int start, int end){
//     if (end == start) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }


// Задача 66: Выполнить с помощью рекурсии.
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.Write($"Натуральные числа в промежутке от {M} до {N}: {SumNumbers(M, N)} ");

// int SumNumbers(int M, int N)
// {
//     if (M == N) return M;
//     int sum = 0;
//     return (sum = M + SumNumbers(M + 1, N));
// }



// Задача 68: Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write($"Функция Аккермана с числами {n} и {m} -> {Ack(n, m)} ");

//------------метод-----------------

 int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

        