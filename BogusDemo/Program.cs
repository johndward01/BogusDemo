using Bogus;

for (int i = 0; i < 100; i++)
{
    var person = new Bogus.Person();
    var fullName = $"{person.FirstName} {person.LastName}";
    Console.WriteLine(fullName);
}



