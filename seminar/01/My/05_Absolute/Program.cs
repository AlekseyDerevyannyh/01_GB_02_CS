Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)	Console.WriteLine("|{0}| = {1}", N, -N);
else		Console.WriteLine("|{0}| = {0}", N);
