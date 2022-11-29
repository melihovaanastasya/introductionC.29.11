// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArray(int m,int n,double min=0,double max=10)
{
    double[,] a=new double[m,n];
    Random random=new Random();
    for(int i=0;i<m;i++)
         for(int j=0;j<n;j++)
                a[i,j]=Math.Round(random.NextDouble()*100,2);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],10}");
           System.Console.WriteLine();
        }
}

double[,] a=Random2DArray(5,6);
Print2DArray(a);