// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string num(int a)
{
if (a>1) return $"{a}, "+num(a-1);
return "1";
}
Console.WriteLine(num(5));