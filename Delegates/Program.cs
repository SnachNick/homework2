// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
internal class TestDel
{
    public delegate void TestDelDelegate(string text);
    static void Print(string message)
    {
        Console.WriteLine(message);
    }

}