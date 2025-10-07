



try
{
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(x / y);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("infinity");
}
catch (FormatException e)
{
    Console.WriteLine("format error");
}
catch (Exception e)
{
    Console.WriteLine("error");
}
