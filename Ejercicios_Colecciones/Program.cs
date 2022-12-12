#region

using System.Collections;

ArrayList array = new ArrayList();
int suma = 0;

for (int i = 0; i < 1000; i++)
{
    array.Add(i + 1);
}


for (int i = 0; i < array.Count; i++)
{
    suma += (int)array[i];
}

Console.WriteLine("El resultado de la suma es: " + suma);

#endregion

#region
List<string> listaNombres = new List<string> { };
Console.WriteLine("Ingresa 5 nombres");
Console.ReadKey();

Console.WriteLine("Ingresa el primer nombre: ");
string nombre = (Console.ReadLine()).ToLower();
listaNombres.Add(nombre);

Console.WriteLine("Ingresa el segundo nombre: ");
nombre = (Console.ReadLine()).ToLower();
listaNombres.Add(nombre);

Console.WriteLine("Ingresa el tercer nombre: ");
nombre = Console.ReadLine();
listaNombres.Add(nombre);

Console.WriteLine("Ingresa el cuarto nombre: ");
nombre = (Console.ReadLine()).ToLower();
listaNombres.Add(nombre);

Console.WriteLine("Ingresa el quinto nombre: ");
nombre = (Console.ReadLine()).ToLower();
listaNombres.Add(nombre);

Console.WriteLine("Nombres recolectados, ahora ingresa un nombre a buscar: : ");
nombre = (Console.ReadLine()).ToLower();

if (listaNombres.Contains(nombre.ToLower()))
{
    Console.WriteLine("El nombre sí se encuentra en la base de datos");
}
else
{
    Console.WriteLine("El nombre NO se encuentró");
}

#endregion

#region

List<int> listaPares = new List<int> { };
List<int> listaImpares = new List<int> { };

void insertList(int numero)
{
    if (numero % 2 == 0)
    {
        listaPares.Add(numero);
    }
    else
    {
        listaImpares.Add(numero);
    }
}

int sumaLista(List<int> lista)
{
    int suma = 0;

    foreach (var numero in lista)
    {
        suma += numero;
    }

    return suma;
}

Console.WriteLine("Ingresa 10 números");
Console.ReadKey();

Console.WriteLine("Ingresa el primer número: ");
int numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el segundo número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el tercer número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el cuarto número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el quinto número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el sexto número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el séptimo número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el octavo número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el noveno número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

Console.WriteLine("Ingresa el décimo número: ");
numero = int.Parse(Console.ReadLine());
insertList(numero);

int sumaPares = sumaLista(listaPares);
int sumaImpares = sumaLista(listaImpares);

Console.WriteLine("La suma de los números pares es: " + sumaPares);
Console.WriteLine("La suma de los números impares es: " + sumaImpares);

#endregion

#region

List<int> listaNumeros = new List<int> { };

Console.WriteLine("Ingresa 10 números");
Console.ReadKey();

Console.WriteLine("Ingresa el primer número: ");
int numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el segundo número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el tercer número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el cuarto número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);
Console.WriteLine("Ingresa el quinto número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el sexto número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el séptimo número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el octavo número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el noveno número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("Ingresa el décimo número: ");
numero = int.Parse(Console.ReadLine());
listaNumeros.Add(numero);

Console.WriteLine("El número más grande de los ingresados es: " + listaNumeros.Max());
Console.WriteLine("El número más pequeño de los ingresados es: " + listaNumeros.Min());

#endregion

#region

void insertarArreglo(int numero, int posicion, int[] arreglo)
{
    arreglo[posicion] = numero;
}

Console.WriteLine("Cuántos elementos tendrá el arreglo?");
int elementosArreglo = int.Parse(Console.ReadLine());
int[] arregloNumeros = new int[elementosArreglo];
int contador = 0;

while (contador < elementosArreglo)
{
    Console.WriteLine("contador: " + contador);

    Console.WriteLine("Valor a insertar: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("Posición del valor: ");
    int posicion = int.Parse(Console.ReadLine());

    insertarArreglo(numero, posicion, arregloNumeros);
    contador++;
}

foreach (var numero in arregloNumeros)
{
    Console.WriteLine("-" + numero);
}

#endregion