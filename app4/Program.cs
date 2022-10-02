Console.WriteLine("vvod: ");
int a = Convert.ToInt32(Console.ReadLine());
char c = '*';
for (int i = 0; i < a; i++)
{
	for (int g = i; g < a; g++)
	{
		Console.Write(c);
	}
	Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
for (int g = 0; g < a; g++)
{
	for (int i = 0; i <=g; i++)
	{
		Console.Write(c);
	}
	Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
char p = ' ';
for (int i = 0; i < a; i++)
{
    for (int g = i; g < a-1; g++)
    {
        Console.Write(p);
    }
	for (int k = 0; k < i+1; k++)
	{
		Console.Write(c);
	}
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
for (int g = 0; g < a; g++)
{
    for (int i = 0; i < g; i++)
    {
        Console.Write(p);
    }
    for (int t = g; t < a; t++)
    {
        Console.Write(c);
    }
    Console.WriteLine();
}