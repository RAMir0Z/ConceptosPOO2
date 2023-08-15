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