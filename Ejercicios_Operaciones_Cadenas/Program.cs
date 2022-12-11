/*#region 

Console.WriteLine("Escribe tu nombre: ");
string nombre = Console.ReadLine().ToLower();

while (nombre != "santiago")
{
    Console.WriteLine("Escribe otro nombre: ");
    nombre = Console.ReadLine().ToLower();
}

Console.WriteLine("Tú nombre es Santiago, el mejor nombre del mundo");

#endregion

#region

Console.WriteLine("Escribe una palabra: ");
string palabra = Console.ReadLine().ToLower();
string palabraInversa = "";


for (int i = palabra.Length - 1; i >= 0 ; i--)
{
    palabraInversa += palabra[i];
}

Console.WriteLine("La palabra inversa es: " + palabraInversa);


#endregion*/