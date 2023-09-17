Console.WriteLine("From which to which number do you wish to see the prime numbers?");
Console.WriteLine("From:");
int limit1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("To:");
int limit2 = Convert.ToInt32(Console.ReadLine());
int counter_1 = 2;
int counter_2 = 0;
while ((limit1 < 11) && (limit1 <= limit2))
{
    while ((limit1 / 2) >= counter_1)
    {
        if ((limit1 % counter_1) == 0)
        {
            counter_2 += 1;
            break;
        }
        counter_1 += 1;
    }    
    if (counter_2 == 0)
    {
        Console.WriteLine(limit1);
    }    
    limit1 += 1;
    counter_1 = 2;
    counter_2 = 0;
}
while ((limit1 >= 11) && (limit1 <= limit2))
{
    while ((limit1 / 4) >= counter_1)
    {
        if ((limit1 % counter_1) == 0)
        {
            counter_2 += 1;
            break;
        }
        counter_1 += 1;
    }    
    if (counter_2 == 0)
    {
        Console.WriteLine(limit1);
    }    
    limit1 += 1;
    counter_1 = 2;
    counter_2 = 0;
}