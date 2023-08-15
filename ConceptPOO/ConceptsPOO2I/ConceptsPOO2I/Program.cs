using ConceptsPOO2I;

Console.WriteLine("Concepts POO 2do Intento");
Console.WriteLine("========================");

try
{
	Console.WriteLine(new Date(2023, 8, 15));
	Console.WriteLine(new Date(2012, 12, 1));
	Console.WriteLine(new Date(2000, 2, 29));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}

Employee employee1 = new SalaryEmployee()
{
	Id = 1111,
	FirstName = "Ana",
	LastName = "Valero",
	BirthDate = new Date(1995, 5, 26),
	HiringDate = new Date(2020, 9, 1),
	IsActive = true,
	Salary = 25000M
};

Employee employee2 = new ComissionEmployee()
{
    Id = 2222,
    FirstName = "Ricardo",
    LastName = "Arjona",
    BirthDate = new Date(1985, 3, 15),
    HiringDate = new Date(2021, 2, 1),
    IsActive = true,
    Sales = 1500000M,
	ComissionPercentaje = 0.05F
};

Employee employee3 = new HourlyEmployee()
{
    Id = 3333,
    FirstName = "Richard",
    LastName = "Watterson",
    BirthDate = new Date(1975, 6, 2),
    HiringDate = new Date(2022, 7, 1),
    IsActive = true,
    HourValue = 250M,
    Hours = 150F
};

Employee employee4 = new BaseComissionEmployee()
{
    Id = 4444,
    FirstName = "Daniel",
    LastName = "Robles",
    BirthDate = new Date(1989, 1, 8),
    HiringDate = new Date(2022, 11, 17),
    IsActive = true,
    Base = 2500M,
    Sales = 800000M,
    ComissionPercentaje = 0.015F
};

////Console.WriteLine(e1);
////Console.WriteLine(e2);
////Console.WriteLine(e3);
////Console.WriteLine(e4);
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                              ==================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Poco X4 Pro",
    Id = 1,
    Price = 4500M,
    Quantity = 3,
};
Invoice invoice2 = new Invoice()
{
    Description = "Arizona de Sandía",
    Id = 2,
    Price = 17M,
    Quantity = 7,
};
Invoice invoice3 = new Invoice()
{
    Description = "Aguacate Hass",
    Id = 3,
    Price = 54M,
    Quantity = 4.2F,
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
Console.WriteLine(invoice3);
