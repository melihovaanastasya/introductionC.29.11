// 64. В двумерном массиве заменить элементы, у котоых оба индекса чётные на их квадраты по значению.

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

void Kvadrat (int[,]a)
{
     for(int i=0;i<a.GetLength(0);i++)
         for(int j=0;j<a.GetLength(1);j++)
         if ((i%2==0) && (j%2==0))
         a[i,j]=a[i,j]*a[i,j];
}

int[,] a=Random2DArray(5,5);
Print2DArray(a);
System.Console.WriteLine();
Kvadrat(a);
Print2DArray(a);