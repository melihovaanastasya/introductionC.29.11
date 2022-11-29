// 66. Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
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

int SumMainDiagonal(int[,] a)
{
    int s=0;
    if (a.GetLength(0)!=a.GetLength(1))
         throw new ArgumentException("Матрица не квадратная");
    for(int i=0;i<a.GetLength(0);i++)            
        s+=a[i,i];
    return s;
}

int[,] a=Random2DArray(4,4);
Print2DArray(a);
try
{
    System.Console.WriteLine(SumMainDiagonal(a));
}
catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
}