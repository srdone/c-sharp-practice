using System;


//Example of lazy loading using properties
class Auto
{
	public Auto(int id, string name)
	{
		this.id = id;
		this.name = name;
	}
	
	public int ProductionCount
	{
		get
		{
			if (productionCount == -1)
			{
				//fetch count
			}
			return return productionCount;
		}
	}
	
	public int SalesCount
	{
		get
		{
			if (salesCount == -1)
			{
				// query data
			}
			return salesCount;
		}
	}
	
	string name;
	string id;
	int productionCount = -1;
	int salesCount = -1;
}