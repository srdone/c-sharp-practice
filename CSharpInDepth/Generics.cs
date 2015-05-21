//Using a Dictionary<TKey, TValue> to count words in text
static Dictionary<string, int> CountWords(string text)
{
	Dictionary<string, int> frequencies; //declare the variable
	frequencies = new Dictionary<string, int>(); //initialize variable
	
	string[] words = Regex.Split(text, @"\W+");
	
	foreach (string word in words)
	{
		if (frequencies.Contains(word))
		{
			frequencies[word]++;
		}
		else
		{
			frequencies[word] = 1;
		}
	}
}

string text = @"Do you like green eggs and ham?
								I do not like them, Sam-I-Am.
								I do not like green eggs and ham."

Dictionary<string, int> frequencies = CountWords(text);
foreach (KeyValuePair<string, int> entry in frequencies)
{
	string word = entry.Key;
	int frequency = entry.Value;
	Console.WriteLine("{0}: {1}", word, frequency);
}