
// 1. 1. Write a program that takes a string input and returns a tuple containing the first and last characters of the input string.

Console.WriteLine("Enter a word:");
string str = Convert.ToString(Console.ReadLine());

var result = Tuple.Create(str.Substring(0, 1), str.Substring(str.Length - 1, 1));
Console.WriteLine(result);

Console.WriteLine("\n");
Console.WriteLine("*************");


//2.Write a program that takes a string input and returns a tuple containing the number of
//uppercase and lowercase letters in the input string.

Console.WriteLine("Enter a word: ");
string input = Console.ReadLine();

int upperCount = 0;
int lowerCount = 0;


for (int i = 0; i < input.Length; i++)
{
	char c = input[i];
	if (char.IsUpper(c))
	{
		upperCount++;
	}
	else if (char.IsLower(c))
	{
		lowerCount++;
	}
}
var counts = (UpperCount: upperCount, LowerCount: lowerCount);

Console.WriteLine("Uppercase count: " + counts.UpperCount);
Console.WriteLine("Lowercase count: " + counts.LowerCount);

Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("*************");


//3. Write a program that takes a list of tuples, where each tuple contains a name and an age,
//and returns a tuple containing the name and age of the oldest person in the list.


List<Tuple<string, int>> people = new List<Tuple<string, int>>()
		{
			Tuple.Create("Dejan", 25),
			Tuple.Create("Petar", 38),
			Tuple.Create("Zoran", 56),

		};

		Tuple<string, int> oldestPerson = GetOldestPerson(people);
		Console.WriteLine("The oldest person is {0}, who is {1} years old.", oldestPerson.Item1, oldestPerson.Item2);
	

	static Tuple<string, int> GetOldestPerson(List<Tuple<string, int>> people)
	{
		Tuple<string, int> oldestPerson = null;

		foreach (var person in people)
		{
			if (oldestPerson == null || person.Item2 > oldestPerson.Item2)
			{
				oldestPerson = person;
			}
		}

		return oldestPerson;
	}


