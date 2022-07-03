// int[]array= new int [8] {1,5,2,7,8,9,5,4};
int[]array = new int[8];
for(int i=0;i<array.Length;i++)
{
    array[i]=new Random().Next(0,5);
}



PrintArray(array);




void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i =0 ; i<array.Length; i++)
    {
        Console.Write( array[i]+ " ");
        
    }
    Console.Write("]");   
}