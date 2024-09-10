
string[] input = Console.ReadLine()
					.Split()
					.Reverse()
					.ToArray();

Stack<string> calc = new Stack<string>(input);

int result = int.Parse(calc.Pop());

while (calc.Count > 0)
{
	string operation = calc.Pop();

	if (operation == "+")
	{
		result += int.Parse(calc.Pop());
	}
	else if (operation == "-")
	{
		result -= int.Parse(calc.Pop());
	}
}

Console.WriteLine(result);

