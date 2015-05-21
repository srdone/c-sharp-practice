using System;
using System.Collections;

class DataValue
{
	public DataValue(string name, object data)
	{
		this.name = name;
		this.data = data;
	}
	
	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}
	
	public object Data
	{
		get
		{
			return data;
		}
		set
		{
			data = value;
		}
	}
	
	string name;
	object data;
}

class DataRow
{
	public DataRow()
	{
		row = new ArrayList();
	}
	
	public void Load()
	{
		row.Add(new DataValue("Id", 5551212));
		row.Add(new DataValue("Name", "Fred"));
		row.Add(new DataValue("Salary", 2355.23m));
	}
	
	public object this[int column]
	{
		get
		{
			return row[column - 1];
		}
		set
		{
			row[column - 1] = value;
		}
	}
	
	ArrayList row;
}

class Test
{
	public static void Main()
	{
		DataRow row = new DataRow();
		row.Load();
		DataValue val = (DataValue) row[1];
		Console.WriteLine("Column 1: {0}", val.Data);
	}
}