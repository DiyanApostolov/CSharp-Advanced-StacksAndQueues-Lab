
int[] input = Console.ReadLine()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

Queue<int> numbers = new Queue<int>(input);

Queue<int> tempResult = new();

foreach (int n in numbers)
{
	if (n % 2 == 0)
	{
		tempResult.Enqueue(n);
	}
}

Console.WriteLine($"{string.Join(", ", tempResult)}");