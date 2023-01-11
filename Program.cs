//Домашняя работа 9
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.*/
/*
void ShowNums(int N)
{
    Console.Write(N+ " ");
    if (N>1) ShowNums(N-1);
}
Console.Write("Input a number ");
int n=Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
*/
/*
int SummOfNums(int M, int N)
{
    if (M<N) return N + SummOfNums(M,N-1);
    else if  (M>N) return M + SummOfNums(M-1,N);
    else if (M==N) return(M);

    return 1;
}
Console.Write("Input a number M ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write($"The sum of the numbers from {m} to {n} is  {SummOfNums(m,n)}");
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int defAckerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M>0 && N==0) return defAckerman(M-1,1);
    else return defAckerman(M-1, defAckerman (M,N-1));
}

Console.Write("Input a number M ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write(defAckerman(m,n));
*/