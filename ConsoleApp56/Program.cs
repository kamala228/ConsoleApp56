double a = 0;
double b = 0;
string op = "";
Console.Write("Введи перше число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи операцію (+, -, *, /): ");
op = Console.ReadLine();
Console.Write("Введи друге число: ");
b = Convert.ToDouble(Console.ReadLine());
if (op == "+")
{
    Console.WriteLine("Результат: " + Add(a, b));
}
else if (op == "-")
{
    Console.WriteLine("Результат: " + Sub(a, b));
}
else if (op == "*")
{
    Console.WriteLine("Результат: " + Mul(a, b));
}
else if (op == "/")
{
    Console.WriteLine("Результат: " + Div(a, b));
}
else
{
    Console.WriteLine("Невідома операція");
}
double Add(double x, double y)
{
    return x + y;
}
double Sub(double x, double y)
{
    return x - y;
}
double Mul(double x, double y)
{
    return x * y;
}
double Div(double x, double y)
{
    if (y == 0)
    {
        Console.WriteLine("На нуль ділити не можна!");
        return 0;
    }
    return x / y;
}