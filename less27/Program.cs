Console.WriteLine("введите число = ");
int a = Convert.ToInt32(Console.ReadLine());
int b=0;
int summ=0;
while(a>0)
{
    b=a%10;
    a=a/10;    
    summ+=b;
}
Console.WriteLine(summ);


