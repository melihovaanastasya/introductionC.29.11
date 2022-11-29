// 63. Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива

int[,] Create2DArray(int n,int m)
{
    int[,] a=new int[n,m];
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=i+j;
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

int[,] a=Create2DArray(4,5);
Print2DArray(a);