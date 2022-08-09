Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
if (N>0)
{
    while (count<N)
    {
        Console.Write (count);
        Console.Write (", ");
        count++;
    }
    Console.WriteLine (N);
}
else
{
  while (count>N)
    {
        Console.Write (count);
        Console.Write (", ");
        count=count-1;
    }
    Console.WriteLine (N);  
}