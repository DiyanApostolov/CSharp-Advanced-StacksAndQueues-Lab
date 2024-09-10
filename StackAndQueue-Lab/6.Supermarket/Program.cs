
Queue<string> people = new Queue<string>();

string command = Console.ReadLine();

while (command != "End")
{
	if (command == "Paid")
	{
		while (people.Count > 0)
		{
			string name = people.Dequeue();
			Console.WriteLine(name);
		}
	}
	else
	{
		people.Enqueue(command);
	}

	command = Console.ReadLine();
}
Console.WriteLine($"{people.Count} people remaining.");

