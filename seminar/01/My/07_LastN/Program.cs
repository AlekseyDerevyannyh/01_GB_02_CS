Console.Clear();
Console.Write("Введите трёхзначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if ((Math.Abs(N) < 100) || (Math.Abs(N) > 999)) {
	Console.WriteLine("Введено не трёхзначное число!!!");
	return;
}
Console.WriteLine(N%10);
