double b1 = ReadTerminal("Введите b1: ");
double k1 = ReadTerminal("Введите k1: ");
double b2 = ReadTerminal("Введите b2: ");
double k2 = ReadTerminal("Введите k2: ");
 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"b1 = {b1},k1 = {k1},b2 = {b2},k2 = {k2} -> ({x};{y})");


// Функция ввода ( строки )
double ReadTerminal(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}