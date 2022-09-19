//Name - Fahmi Awol
//Date - 09/17
// This is the main program that inquiries information from the user input and prints it.

// See https://aka.ms/new-console-template for more information

using Project_NorthWind;

Console.WriteLine("Hello, Please Fill in the Information Below");
Console.WriteLine("\n");

//Creating new catagories
Category aCategory1 = new Category();
Category aCategory2 = new Category();
Category aCategory3 = new Category();
Category aCategory4 = new Category();

Console.WriteLine("Enter the Category Id 1:");
aCategory1.CategoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Category Name 1:");
aCategory1.CategoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 1:");
aCategory1.Description = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Enter the Category Id 2:");
aCategory2.CategoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Category Name 2:");
aCategory2.CategoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 2:");
aCategory2.Description = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Enter the Category Id 3:");
aCategory3.CategoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Category Name 3:");
aCategory3.CategoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 3:");
aCategory3.Description = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Enter the Category Id 4:");
aCategory4.CategoryId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Category Name 4:");
aCategory4.CategoryName = Console.ReadLine();
Console.WriteLine("Enter the Description 4:");
aCategory4.Description = Console.ReadLine();

Console.WriteLine("\n");

//Creating a new list for Category
List<Category> aListOfCategory = new List<Category>();
aListOfCategory.Add(aCategory1);
aListOfCategory.Add(aCategory2);
aListOfCategory.Add(aCategory3);
aListOfCategory.Add(aCategory4);

//Creating new customer
Customer aCoustomer1 = new Customer();

Console.WriteLine("Enter The Customer Id");
aCoustomer1.CustomerId = Console.ReadLine();

Console.WriteLine("Enter The Company Name");
aCoustomer1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter your contact name");
aCoustomer1.ContactName = Console.ReadLine();
Console.WriteLine("Enter your contact title");
aCoustomer1.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter your address");
aCoustomer1.Address = Console.ReadLine();
Console.WriteLine("Enter your city");
aCoustomer1.City = Console.ReadLine();
Console.WriteLine("Enter your region");
aCoustomer1.Region = Console.ReadLine();
Console.WriteLine("Enter the postal code");
aCoustomer1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the country ");
aCoustomer1.Country = Console.ReadLine();
Console.WriteLine("Enter your phone number");
aCoustomer1.Phone = Console.ReadLine();
Console.WriteLine("Enter the fax");
aCoustomer1.Fax = Console.ReadLine();

//Creating a list for customer
List<Customer> aListOfCustomer = new List<Customer>();
aListOfCustomer.Add(aCoustomer1);


//Creating a new employee
Employee aEmployee1 = new Employee();

Console.WriteLine("Enter the Employee Id");
aEmployee1.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Last Name");
aEmployee1.LastName = Console.ReadLine();
Console.WriteLine("Enter First Name");
aEmployee1.FirstName = Console.ReadLine();
Console.WriteLine("Enter your Title");
aEmployee1.Title = Console.ReadLine();
Console.WriteLine("Enter the Title of courtesy");
aEmployee1.TitleOfCourtesy = Console.ReadLine();
Console.WriteLine("Enter Birthday");
aEmployee1.BirthDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter hire Day");
aEmployee1.Hiredate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter Address");
aEmployee1.Address = Console.ReadLine();
Console.WriteLine("Enter City");
aEmployee1.City = Console.ReadLine();
Console.WriteLine("Enter Region");
aEmployee1.Region = Console.ReadLine();
Console.WriteLine("Enter Postal Code");
aEmployee1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter Country");
aEmployee1.Country = Console.ReadLine();
Console.WriteLine("Enter Home phone");
aEmployee1.HomePhone = Console.ReadLine();
Console.WriteLine("Enter Extension");
aEmployee1.Extension = Console.ReadLine();
Console.WriteLine("Enter Notes");
aEmployee1.Notes = Console.ReadLine();
Console.WriteLine("Enter Reports to");
aEmployee1.ReportsTo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

//Creating a new list for employee
List<Employee> aListOfEmployee = new List<Employee>();
aListOfEmployee.Add(aEmployee1);


//Creating a new order detail
OrderDetail aOrderDetail1 = new OrderDetail();

Console.WriteLine("Enter Order Id ");
aOrderDetail1.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ender Product Id ");
aOrderDetail1.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter unit price");
aOrderDetail1.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter quantity");
aOrderDetail1.Quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the discount");
aOrderDetail1.Discount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n");

//Creating a list for orderDetail
List<OrderDetail> aListOfOrderDetail = new List<OrderDetail>();
aListOfOrderDetail.Add(aOrderDetail1);


//Creating a new order
Order aorder1 = new Order();

Console.WriteLine("Enter Order ID");
aorder1.OrderId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Coustomer ID");
aorder1.CustomerId = Console.ReadLine();
Console.WriteLine("Enter Employee Id");
aorder1.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter OrderDate");
aorder1.OrderDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter Required Date");
aorder1.RequiredDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter Shipped Date");
aorder1.ShippedDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Enter ShipVia");
aorder1.ShipVia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Freight");
aorder1.Freight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Enter Ship Name");
aorder1.ShipName = Console.ReadLine();
Console.WriteLine("Enter Ship Address");
aorder1.ShipAddress = Console.ReadLine();
Console.WriteLine("Enter Ship Date");
aorder1.ShipCity = Console.ReadLine();
Console.WriteLine("Enter Ship Region");
aorder1.ShipRegion = Console.ReadLine();
Console.WriteLine("Enter Ship Postal Code");
aorder1.ShipPostalCode = Console.ReadLine();
Console.WriteLine("Enter Ship Country");
aorder1.ShipCountry = Console.ReadLine();
Console.WriteLine("\n");

//Creating a list for order
List<Order> aListOfOrder = new List<Order>();
aListOfOrder.Add(aorder1);


//Creating a new Product
Product aProduct1 = new Product();

Console.WriteLine("Enter the 1 ProductID");
aProduct1.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Product Nme");
aProduct1.ProductName = Console.ReadLine();
Console.WriteLine("Enter the 1 Supplier ID");
aProduct1.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Quantity Per Unit");
aProduct1.QuantityPerUnit = Console.ReadLine();
Console.WriteLine("Enter the 1 Unit Price");
aProduct1.UnitPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the 1 Unit in stock");
aProduct1.UnitsInStock = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Unit On order");
aProduct1.UnitsOnOrder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Re Order Level");
aProduct1.ReorderLevel = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Discontinued?");
aProduct1.Discontinued = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("\n");

//Creating a list for product
List<Product> aListOfProduct = new List<Product>();
aListOfProduct.Add(aProduct1);


//Creating a new shipper
Shipper ashipper1 = new Shipper();

Console.WriteLine("Enter the 1 ShipperID");
ashipper1.ShipperId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 CompanyNAme");
ashipper1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 1 Phone");
ashipper1.Phone = Console.ReadLine();
Console.WriteLine("\n");

//Creating a new list for shipper
List<Shipper> aListOfShipper = new List<Shipper>();
aListOfShipper.Add(ashipper1);


//Creating a new supplier
Supplier asupplier1 = new Supplier();

Console.WriteLine("Enter the 1 SupplierID");
asupplier1.SupplierId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 1 Company Name");
asupplier1.CompanyName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact Name");
asupplier1.ContactName = Console.ReadLine();
Console.WriteLine("Enter the 1 Contact title");
asupplier1.ContactTitle = Console.ReadLine();
Console.WriteLine("Enter the 1 Address");
asupplier1.Address = Console.ReadLine();
Console.WriteLine("Enter the 1 City");
asupplier1.City = Console.ReadLine();
Console.WriteLine("Enter the 1 Region");
asupplier1.Region = Console.ReadLine();
Console.WriteLine("Enter the 1 Postal code");
asupplier1.PostalCode = Console.ReadLine();
Console.WriteLine("Enter the 1 Country");
asupplier1.Country = Console.ReadLine();
Console.WriteLine("Enter the 1 Phone");
asupplier1.Phone = Console.ReadLine();
Console.WriteLine("Enter the 1 Fax");
asupplier1.Fax = Console.ReadLine();
Console.WriteLine("Enter the 1 Home Page");
asupplier1.HomePage = Console.ReadLine();
Console.WriteLine("\n");

//Creating a list for supplier
List<Supplier> aListOfSupplier = new List<Supplier>();
aListOfSupplier.Add(asupplier1);


//Creating a loop for Category
foreach (var c in aListOfCategory)
{
    Console.WriteLine(c.ToString());
    Console.WriteLine("\n\n\n");
}
//Creating a loop for Customer
foreach (var d in aListOfCustomer)
{
    Console.WriteLine(d.ToString());
    Console.WriteLine("\n\n\n");
}
//Creating a loop for Employee
foreach (var e in aListOfEmployee)
{
    Console.WriteLine(e.ToString);
    Console.WriteLine("\n\n\n");
}
//Creating a loop for order details
foreach (var f in aListOfOrderDetail)
{
    Console.WriteLine(f.ToString);
    Console.WriteLine("\n\n\n");
}
//Creating a loop for Order
foreach (var g in aListOfOrder)
{
    Console.WriteLine(g.ToString);
    Console.WriteLine("\n\n\n");
}

//Creating a loop for product
foreach (var h in aListOfProduct)
{
    Console.WriteLine(h.ToString);
    Console.WriteLine("\n\n\n");
}
//Creating a loop for shipper
foreach (var i in aListOfShipper)
{
    Console.WriteLine(i.ToString());
    Console.WriteLine("\n\n\n");
}

//Creating a loop
foreach (var h in aListOfSupplier)
{
    Console.WriteLine(h.ToString);
    Console.WriteLine("\n\n\n");
}


