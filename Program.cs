/// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    if(n>1) ShowNums(n-1);
    Console.Write(n + " ");
}


ShowNums(34);
*/

//// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*

int SumNum (int n, int m)
{
    int s = 0;
    for(int i = n; i <= m; i++)
    {
        if(i % 1 == 0)
        s = s + i;
        
    }
    return  s ;
}

Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n,m));
*/


//// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Akkerman(int m, int n)
{
    if(m==0)
    { 
        return n+1;

    }
    if(m> 0 && n==0)
    {
         return Akkerman(m-1,1);

    }
    return Akkerman(m-1, Akkerman(m,n-1));


}

Console.WriteLine(Akkerman(1,2));