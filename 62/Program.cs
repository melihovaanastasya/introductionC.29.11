﻿// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] Random2DArray(int m,int n,int min=0,int max=10)
{
    int[,] a=new int[m,n];
    Random random=new Random();
    for(int i=0;i<m;i++)
         for(int j=0;j<n;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

void Protiv (int [,]a)
{
    for(int i=0;i<a.GetLength(0);i++)
         for(int j=0;j<a.GetLength(1);j++)
                a[i,j]=-a[i,j];
}

int[,] a=Random2DArray(5,6);
Print2DArray(a);
System.Console.WriteLine();
Protiv (a);
Print2DArray(a);