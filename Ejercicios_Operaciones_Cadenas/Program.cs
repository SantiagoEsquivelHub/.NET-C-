#region 

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


#endregion

#region

Console.WriteLine("Ingresa una frase de al menos 20 caracteres y 4 palabras: ");
string frase20 = Console.ReadLine();
string[] prueba = frase20.Split();

while (frase20.Length < 20 && prueba.Length < 4)
{
    Console.WriteLine("La frase debe tener al menos 20 caracteres y 4 palabras, inténtalo de nuevo: ");
    frase20 = Console.ReadLine();
}



//*longitud de la cadena

Console.WriteLine($"Longitud de la cadena: {frase20.Length}");

//*pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" se cambiara por una "x" y si es "A" se cambiara por una "X"

//*pinta la cadena en mayúsculas
Console.WriteLine($"Cadena en mayúsculas: {frase20.ToUpper()}");

//*pinta la cadena en minúsculas
Console.WriteLine($"Cadena en minúsculas: {frase20.ToLower()}");

//*pinta la cadena, removiendo las 3 primeras letras
string primera3Letras = frase20.Remove(3);
string nuevaCadena = frase20.Replace(primera3Letras, "");

Console.WriteLine($"Cadena sin las primeras 3 letras: {nuevaCadena}");

//*pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10

string nuevaCadena2 = frase20.Remove(5, 5);

Console.WriteLine($"Cadena sin las letras de la posición 5 a la 10: {nuevaCadena2}");

//*invierte la cadena

string fraseInversa = "";

for (int i = frase20.Length - 1; i >= 0; i--)
{
    fraseInversa += frase20[i];
}

Console.WriteLine($"Cadena invertida: {fraseInversa}");

//*escribe el numero de palabras que tiene la frase
Console.WriteLine($"Número de palabras que tiene la frase : {prueba.Length}");


//*escribe únicamente la tercera palabra
Console.WriteLine($"Tercera palabra de la frase : {prueba[3]}");

#endregion

#region

using System.Text;

Console.WriteLine("Ingresa 4 números");
Console.WriteLine("Primer número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Tercer número: ");
int numero3 = int.Parse(Console.ReadLine());

Console.WriteLine("Cuarto número: ");
int numero4 = int.Parse(Console.ReadLine());

StringBuilder fraseFinal = new StringBuilder();

Console.WriteLine($"El primer numero introducido es el {numero1}, despues han introducido el {numero2} y {numero3} y por ultimo el {numero4}");

#endregion

#region

for (char i = 'Z'; i >= 'A'; i--)
{
    Console.WriteLine("-"+i);
}


#endregion