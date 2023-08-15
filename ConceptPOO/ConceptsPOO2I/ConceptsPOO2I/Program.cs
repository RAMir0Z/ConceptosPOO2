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

Employee e1 = new SalaryEmployee()
{
	Id = 1,
	FirstName = "Ana",
	LastName = "Valero",
	BirthDate = new Date(1995, 5, 26),
	HiringDate = new Date(2020, 9, 1),
	IsActive = true,
	Salary = 25000M
};

Employee e2 = new ComissionEmployee()
{
    Id = 2,
    FirstName = "Ricardo",
    LastName = "Arjona",
    BirthDate = new Date(1985, 3, 15),
    HiringDate = new Date(2021, 2, 1),
    IsActive = true,
    Sales = 1500000M,
	ComissionPercentaje = 0.05F
};
Console.WriteLine(e1);
Console.WriteLine(e2);