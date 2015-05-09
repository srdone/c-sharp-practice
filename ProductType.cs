using System.Collections.Generic;
public class Product
{

	readonly string name;
	public string Name { get { return name; } };
	
	public decimal? Price { get { return price; } };
	
	public Product(string name, decimal? price = null)
	{
		this.name = name;
		this.price = price;
	}
	
	public static List<Product> GetSampleProducts()
	{
		return new List<Product>
		{
			new Product{ name: "West Side Story", price: 9.99m },
			new Product{ name: "Assassins", 			price: 14.99m },
			new Product{ name: "Frogs", 					price: 13.99m },
			new Product{ name: "Sweeney Todd", 		price: 10.99m } 
		}
	}
	
	public override string toString()
	{
		return string.Format("{0}: {1}", Name, Price);
	}
}

List<Product> products = Product.GetSampleProducts();
foreach (Product product in products.OrderBy(p => p.Name))
{
	Console.WriteLine (product);
}

ArrayList products = Product.GetSampleProducts();
foreach (Product product in products.Where(p => p.Price > 10m))
{
	Console.WriteLine(product);
}

ArrayList products = Product.GetSampleProducts();
foreach (Product product in products.Where(p => p.Price.HasValue))
{
	Console.WriteLine(product);
}

List<Product> products = Product.GetSampleProducts();
var filtered = from Product p in products
							where p.Price > 10
							select p;
foreach (Product p in filtered)
{
	Console.WriteLine(product);
}

List<Product> products = Product.GetSampleProducts();
List<Supplier> suppliers = Supplier.GetSampleSuppliers();
var filtered = from p in products
							join s in suppliers
								on p.SupplierID equals s.SupplierId
							where p.Price > 10
							orderby s.Name, p.Name
							select new { SupplierName = s.Name, ProductName = p.Name };
foreach (var v in filtered)
{
	Console.WriteLine("Supplier={0}, Product={1}", v.SupplierName, v.ProductName);
}


//LINQ and XML
XDocument doc = XDocument.Load("data.xml")
var filtered = from p in doc.Decendants("Product")
							join s in doc.Decendants("Supplier")
								on (int)p.Attribute("SupplierID")
								equals (int)s.Attribute("SupplierID")
							where (decimal)p.Attribute("Price") > 10
							orderby (string)s.Attribute("Name")
											(string)p.Attribute("Name")
							select new
							{
								SupplierName = (string)s.Attribute("Name"),
								ProductName = (string)p.Attribute("Name")
							}
for (var v in filtered)
{
	Console.WriteLine("Supplier={0}, Product={1}", v.SupplierName, v.ProductName);
}

//LINQ and SQL DB
using (LinqDemoDataContext db = new LinqDemoDataContext())
{
	var filtered = from p in db.Products
									join s in db.Suppliers
										on p.SupplierID equals s.SupplierID
									where p.Price > 10
									orderby s.Name, p.Name
									select new
									{
										SupplierName = s.Name
										ProductName = p.Name
									}
	foreach (var v in filtered)
	{
		Console.WriteLine("Supplier={0}; Product={1}",
											v.SupplierName, v.ProductName);
	}
}