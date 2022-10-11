Console.Clear();
Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if ( (a * a) == b)	Console.WriteLine("Число b является квадратом числа a");
else				Console.WriteLine("Число b не является квадратом числа a");
