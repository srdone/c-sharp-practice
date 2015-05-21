using System;
using System.IO;

class Processor
{
	int count;
	int sum;
	public int average;
	void CalculateAverage(int countAdd, int sumAdd)
	{
		count += countAdd;
		sum += sumAdd;
		average = sum / count;
	}
	
	public void ProcessFile(string filename)
	{
		FileStream f = new FileStream(filename, FileMode.Open);
		try
		{
			StreamReader t = new StreamReader(f);
			string line;
			while ((line = t.ReadLine()) != null)
			{
				int count;
				int sum;
				count = int.Parse(line);
				line = t.ReadLine();
				sum = int.Parse(line);
				CalculateAverage(count, sum);
			}
		}
		finally
		{
			f.Close();
		}
	}
}

class Test
{
	public static void Main(string[] args)
	{
		Processor processor = new Processor();
		try
		{
			processor.ProcessFile(args[0]);
			Console.WriteLine("Average: {0}", processor.average);
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception: {0}", e);
		}
	}
}