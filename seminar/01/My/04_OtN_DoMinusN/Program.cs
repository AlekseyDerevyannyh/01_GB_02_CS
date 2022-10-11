Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)		Console.WriteLine("Ошибка!");
else {
	int count = -N;
	while (count <= N) {
		Console.WriteLine(count);
		count ++;
	}
}
