using Ejercicios_Clases_POO;
using System.Xml.Linq;

/*#region

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

#endregion*/

#region

Console.WriteLine("We need the age and name of 5 people");
Console.ReadLine();

int peopleCounter = 1;
List<Student> students = new List<Student>();
List<Teacher> teachers = new List<Teacher>();

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

    Console.WriteLine("Are you a teacher of a student? ");
    string position = Console.ReadLine();

    while (position.ToLower() != "student" && position.ToLower() != "teacher")
    {
        Console.WriteLine("Enter a valid position");
        position = Console.ReadLine();
    }


    if (position.ToLower() == "student")
    {
        Console.WriteLine("Enter your student ID:");
        int id = int.Parse(Console.ReadLine());
        Student student = new Student(id, age, name);
        students.Add(student);

    }
    else
    {
        Console.WriteLine("Enter the name of the subject:");
        string subject = Console.ReadLine();
        Teacher teacher = new Teacher(subject, age, name);
        teachers.Add(teacher);
    }

    peopleCounter++;
}

Console.WriteLine("-------------------------<ADULTS>-------------------------");
foreach (var student in students)
{
    if (student.age >= 18)
    {
        Console.WriteLine("-------------------------<STUDENT>-------------------------");
        Console.WriteLine("Id: " + student.id);
        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Age: " + student.age);
        Console.WriteLine("-------------------------</STUDENT>-------------------------");
    }
}

foreach (var teacher in teachers)
{
    if (teacher.age >= 18)
    {
        Console.WriteLine("-------------------------<TEACHER>-------------------------");
        Console.WriteLine("Subject: " + teacher.subject);
        Console.WriteLine("Name: " + teacher.name);
        Console.WriteLine("Age: " + teacher.age);
        Console.WriteLine("-------------------------</TEACHER>-------------------------");
    }
}
Console.WriteLine("-------------------------</ADULTS>-------------------------");



#endregion
