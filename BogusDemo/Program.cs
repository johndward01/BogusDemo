using Bogus;

Person person;

for (int i = 0; i < 1000; i++)
{
    person = new Person();
    Console.WriteLine(person.FullName);
}

