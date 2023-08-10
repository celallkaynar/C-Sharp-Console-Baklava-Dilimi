int boyut, i, j;
Console.Write("Boyut Giriniz: ");
boyut=Convert.ToInt16(Console.ReadLine());
for (i = 1; i <= boyut; i++)
{
    for(int k=boyut; k >=i; k--)
    {
        Console.Write(" ");
    }
    for (j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
for (i = boyut-1; i >= 1; i--)
{
    for (int k = boyut; k >= i; k--)
    {
        Console.Write(" ");
    }
    for (j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
