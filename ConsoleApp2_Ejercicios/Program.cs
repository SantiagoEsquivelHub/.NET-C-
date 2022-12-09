// See https://aka.ms/new-console-template for more information
#region
using System.Diagnostics;
using System.Linq.Expressions;

int numero1 = 1;
int numero2 = 2;
int numero3 = 3;
int suma = numero1 + numero2 + numero3;
Console.WriteLine("El resultado de la suma es: " + suma);
Console.ReadKey();
#endregion

#region
Console.WriteLine("Ingresa un número: ");
string n1 = Console.ReadLine();
Console.WriteLine("Ingresa otro número: ");
string n2 = Console.ReadLine();
Console.WriteLine("El número mayor es: " + (int.Parse(n1) > int.Parse(n2) ? n1 : n2));
Console.ReadKey();
#endregion

#region
Console.WriteLine("Ingresa un día de la semana: ");
string dia = Console.ReadLine();

switch (dia)
{
    case "Sábado":
        Console.WriteLine("Sí es un día del fin de semana");
        break;
    case "Domingo":
        Console.WriteLine("Sí es un día del fin de semana");
        break;
    default: 
        Console.WriteLine("NO es un día del fin de semana");
        break;
}
Console.ReadKey();
#endregion

#region
Console.WriteLine("Ingrese el precio del producto: ");
string precioProducto = Console.ReadLine();
Console.WriteLine("Ingrese su método de pago: ");
string metodoPago = Console.ReadLine();
if (metodoPago == "tarjeta")
{
    Console.WriteLine("Ingrese el número de la tarjeta: ");
    string numeroTarjeta = Console.ReadLine();
}
Console.ReadKey();
#endregion

#region
for (int i = 1; i <= 100; i++)
{
Console.WriteLine(i);

}
#endregion

#region
int i = 1;
while (i <= 100)
{
    Console.WriteLine(i);
    i++;
}
#endregion

#region
int i = 1;
while (i <= 100)
{
    if (i % 2 == 0)
    {
    Console.WriteLine(i);
    }
    i++;
}
#endregion

#region
int i = 1;
while (i <= 100)
{
    if (i % 2 == 0 || i % 3 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
#endregion

#region
int[] array = new int[50];
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        array[(i-1)/2] = i;

    }
    
}
Console.WriteLine(String.Join(", ", array));
#endregion

#region

Console.WriteLine("Ingresa un número: ");
string n1 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n2 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n3 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n4 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n5 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n6 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n7 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n8 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n9 = Console.ReadLine();
Console.WriteLine("Ingresa un número: ");
string n10 = Console.ReadLine();

List<string> lista = new List<string>{n1, n2, n3, n4, n5, n6, n7 ,n8, n9, n10};

int pares = 0;
int impares = 0;

foreach (var item in lista)
{
    int num = int.Parse(item);

    if (num % 2 == 0)
    {
        pares += num;
    }
    else{
        impares += num;

    }
}

int resultado = pares - impares;

Console.WriteLine("El resultado es: " + resultado);
#endregion

#region
Console.WriteLine("Ingresa un número del 1 al 7: ");
string dia = Console.ReadLine();

switch (dia)
{
    case "1":
        Console.WriteLine("Lunes");
        break;
    case "2":
        Console.WriteLine("Martes");
        break;
    case "3":
        Console.WriteLine("Miercoles");
        break;
    case "4":
        Console.WriteLine("Jueves");
        break;
    case "5":
        Console.WriteLine("Viernes");
        break;
    case "6":
        Console.WriteLine("Sábado");
        break;
    case "7":
        Console.WriteLine("Domingo");
        break;

}
#endregion

#region
Console.WriteLine("Ingresa un número del 1 al 1000: ");
string numeroStr = Console.ReadLine();
int numero = int.Parse(numeroStr);

while (!(numero >= 1 && numero <= 1000))
{
    Console.WriteLine("El número NO está dentro del rango, ingresa otro número que cumpla la condición: ");
    numeroStr = Console.ReadLine();
    numero= int.Parse(numeroStr);
}


    int i = 1;
    int suma = 0;
    while (i <= numero)
    {
        suma += i;
        i++;
    }

    Console.WriteLine("El resultado es: " + suma);


#endregion

#region
Console.WriteLine("Ingresa un número para saber si es primo: ");
string numeroStr = Console.ReadLine();
int numero = int.Parse(numeroStr);
void numeroPrimo(int? numero)
{
    int? aux = numero - 1;
    bool esPrimo = false;

    while (aux > 1 && aux < numero)
    {
        if (numero % aux == 0)
        {
            esPrimo = false;
            break;
        }

        aux--;
    }

    if (esPrimo)
    {
        Console.WriteLine("El número" + numero + " es primo");
    }
    else
    {
        Console.WriteLine("El número" + numero + " NO es primo");
    }

}

numeroPrimo(numero);

#endregion

#region
Console.WriteLine("Ingrese un número entero positivo para saber cuantas cifras tiene: ");
string numeroStr = Console.ReadLine();
int numero = int.Parse(numeroStr);
int contadorCifras = 0;
int dividir = numero;

while (dividir > 0)
{
    dividir /= 10;
    contadorCifras++;
}

Console.WriteLine("El número " + numero + " tiene " + contadorCifras + " cifras");
#endregion