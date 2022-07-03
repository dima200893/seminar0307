Console.WriteLine("введите число A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B = ");
int b = Convert.ToInt32(Console.ReadLine());
int result=0;
int test=1;
for(int i=1;i<=b;i++)
{
    result=test*a;
    test=result;
}
 Console.WriteLine(test);

