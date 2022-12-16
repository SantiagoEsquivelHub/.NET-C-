#region

using Ejercicios_Clases_POO_3;

int num1 = 2;
int num2 = 7;
int result = Add.addNumbers(2,7);

Console.WriteLine("The result of add " + num1 + " and " + num2 + " is " + result);

#endregion

#region

Animal katty = new Animal("dog", "gray", true, 4);
string domestic = katty.isDomestic ? "I'm domestic" : "I'm not domestic";
Console.WriteLine($"Hi, I'm Katty and I'm a {katty.type}, my hair color is {katty.hairColor}, {domestic} and I have {katty.paws} paws" );

#endregion

