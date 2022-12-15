#region

using Ejercicios_Clases_POO;
using System.Xml.Linq;

Console.WriteLine("We need the age and name of 5 people");
Console.ReadLine();

int peopleCounter = 1;
List<Person> people = new List<Person>();

while (peopleCounter <= 5)
{

    Console.WriteLine("Enter the data of a person");
    Console.WriteLine("Age: ");
    int age;
    int.TryParse(Console.ReadLine(), out age);

    while (age <= 0)
    {
        Console.WriteLine("Enter a valid age");
        Console.WriteLine("Age: ");
        age = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Name: ");
    string name = Console.ReadLine();

    while (name.Length < 2)
    {
        Console.WriteLine("Enter a valid name");
        Console.WriteLine("Name: ");
        name = Console.ReadLine();
    }

    Person person = new Person(age, name);
    people.Add(person);
    peopleCounter++;
}

Console.WriteLine("-------------------------<ADULTS>-------------------------");
foreach (var person in people)
{
    if (person.age >= 18)
    {
        Console.WriteLine("-------------------------<PERSON>-------------------------");
        Console.WriteLine("Name: " + person.name);
        Console.WriteLine("Age: " + person.age);
        Console.WriteLine("-------------------------</PERSON>-------------------------");
    }
}
Console.WriteLine("-------------------------</ADULTS>-------------------------");





#endregion
