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

class DataRow : IEnumerable
{
	class DataRowEnumerator : IEnumerator
	{
		public DataRowEnumerator(DataRow dataRow)
		{
			this.dataRow = dataRow;
			index = -1;
		}
		
		public bool MoveNext()
		{
			index++;
			if (index >= dataRow.row.Count)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		
		public void Reset()
		{
			index = -1;
		}
		
		public object Current
		{
			get
			{
				return (dataRow.row[index]);
			}
		}
		DataRow dataRow;
		int index;
	}
	
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
	
	int FindColumn(string name)
	{
		for (int index = 0; index < row.Count; index++)
		{
			DataValue dataValue = (DataValue) row[index];
			if (dataValue.Name == name)
			{
				return index;
			}
		}
		return -1;
	}
	
	public object this[string name]
	{
		get
		{
			return this[FindColumn(name)];
		}
		set
		{
			this[FindColumn(name)] = value;
		}
	}
	
	public IEnumerator GetEnumerator()
	{
		return (IEnumerator) new DataRowEnumerator(this);
	}
	
	ArrayList row;
}

class Test
{
	public static void Main()
	{
		DataRow row = new DataRow();
		row.Load();
		foreach (DataValue dataValue in row)
		{
			Console.WriteLine(
				"{0}: {1}", dataValue.Name, dataValue.Data
			);
		}
	}
}