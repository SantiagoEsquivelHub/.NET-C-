#region 

Console.WriteLine("Ingrese el tipo de cambio que requiere (dolar o euro): ");
string tipoCambio = Console.ReadLine();
string dolar = "dolar";
string euro = "euro";

while (tipoCambio != dolar && tipoCambio != euro)
{
    Console.WriteLine("Tipo de cambio incorrecto, inténtalo de nuevo (dolar o euro): ");
    tipoCambio = Console.ReadLine();
}

Console.WriteLine("Ingrese el valor a cambiar: ");
string valorStr = Console.ReadLine();
double valorCambio = double.Parse(valorStr);

// 1 COP = 0,000207861 USD 
// 1 COP = 0,000197161 EUR 

double copToUsd = 0.000207861;
double copToEur = 0.00019713702;
double resultado = 0;

if (tipoCambio == "dolar")
{
    resultado = (valorCambio * copToUsd);
}
else
{
    resultado = (valorCambio * copToEur);
}

Console.WriteLine("El cambio de " + valorCambio + " a " + tipoCambio + " es: " + resultado);

#endregion

#region 
Console.WriteLine("-------------Menu-------------");
Console.WriteLine("-------------1) Suma-------------");
Console.WriteLine("-------------2) Resta-------------");
Console.WriteLine("-------------3) Multiplicación-------------");
Console.WriteLine("-------------4) División-------------");
Console.WriteLine("Ingrese el código de la operación a realizar: ");
string operacion = Console.ReadLine();

while (operacion != "1" && operacion != "2" && operacion != "3" && operacion != "4" && operacion != "5"){
    Console.WriteLine("Operacion incorrecta, inténtalo de nuevo:  ");
    operacion = Console.ReadLine();
}

Console.WriteLine("Ingresa un número:  ");
string numero1Str = Console.ReadLine();
int n1 = int.Parse(numero1Str);

Console.WriteLine("Ingresa otro número:  ");
string numero2Str = Console.ReadLine();
int n2 = int.Parse(numero2Str);

dynamic resultado = 0;

switch (operacion)
{
    case "1":
        resultado = Suma(n1, n2);
        break;
    case "2":
        resultado = Resta(n1, n2);
        break;
    case "3":
        resultado = Multiplicacion(n1, n2);
        break;
    case "4":
        resultado = Division(n1, n2) == 0 ? "Infinito" : Division(n1, n2);
        break;
}


int Suma(int n1, int n2)
{
    return n1 + n2;
}

int Resta(int n1, int n2)
{
    return n1 - n2;
}

int Multiplicacion(int n1, int n2)
{
    return n1 * n2;
}

int Division(int n1, int n2)
{
    if (n2 == 0)
    {
        Console.WriteLine("No se puede realizar una división por cero");
        return 0;
    }
    return n1 / n2;
}

Console.WriteLine("El resultado de la operación #" + operacion + " es: " + resultado);
#endregion

#region 

#endregion

#region 

Console.WriteLine("Teclea una tecla del teclado para saber su tipo: ");
string elementoStr = Console.ReadLine();


bool EsVocal(dynamic elemento)
{
    return elemento == "a" || elemento == "e" || elemento == "i" || elemento == "o" || elemento == "u" ? true : false;
}

bool EsNumero(dynamic elemento)
{
    int numero = 0;
    bool isNumber = int.TryParse(elemento, out numero);
    return numero.GetType() == Type.GetType("System.Int32") && isNumber ? true : false;
}

//(B, C, D, F, G, H, J, K, L, M, Ñ, P, Q, R, S, T, V, W, X, Y, Z) 

bool EsConsonante(dynamic elemento)
{
    return !EsVocal(elemento) ? true : false;
}

if (EsNumero(elementoStr))
{
    Console.WriteLine("La tecla seleccionada si es un número");
}
else if (EsVocal(elementoStr))
{
    Console.WriteLine("La tecla seleccionada si es una vocal");
} else if (EsConsonante(elementoStr))
{
    Console.WriteLine("La tecla seleccionada si es una consonante");
}

#endregion

#region 

Console.WriteLine("Ingresa un número para saber su tabla de multiplicar: ");
int numero = int.Parse(Console.ReadLine());

void TablaDeMultiplicar(int numero)
{
    int i = 1;

    while (i <= 10)
    {
        Console.WriteLine(numero + " x " + i + "= " + (numero * i));
        i++;
    }
}

TablaDeMultiplicar(numero);

#endregion

#region

using System;

Console.WriteLine("Ingresa un número: ");
int numero = int.Parse(Console.ReadLine());
List<int> listaNumeros = new List<int> { };

while (numero != 0)
{
    listaNumeros.Add(numero);
    Console.WriteLine("Ingresa otro número: ");
    numero = int.Parse(Console.ReadLine());
}

//numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos

int max = listaNumeros.Max();
int min = listaNumeros.Min();
int diferencia = max - min;
int cantidad = listaNumeros.Count();

Console.WriteLine("El número más alto de ingresados es: " + max);
Console.WriteLine("El número más bajo de ingresados es: " + min);
Console.WriteLine("La diferencia del número más alto y el más bajo es: " + diferencia);
Console.WriteLine("La cantidad de números introducidos es: " + cantidad);

#endregion

#region

Console.WriteLine("Ingresa el valor del importe: ");
int importe = int.Parse(Console.ReadLine());


List<int> lista = new List<int>() {100000, 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50};
List<string> listaResultado = new List<string>();

while (importe < 50)
{
    Console.WriteLine("Ingresa un valor válido de importe: ");
    importe = int.Parse(Console.ReadLine());
}

double resto = 0;
for (int i = 0; i < lista.Count(); i++)
{
    while (importe / lista[i] > 0)
    {
        //Console.WriteLine("importe pre: " + importe);

        resto = importe % lista[i];
        importe = importe / lista[i];

        //Console.WriteLine("importe post: " + importe);
        //Console.WriteLine("lista[i]: " + lista[i]);
        //Console.WriteLine("resto: " + resto);

        if (lista[i] == 1000)
        {
            listaResultado.Add(importe + " billetes/monedas de " + lista[i]);
        }else if (lista[i] < 1000)
        {
            listaResultado.Add(importe + " monedas de " + lista[i]);
        }else
        {
            listaResultado.Add(importe + " billetes de " + lista[i]);
        }

        importe = (int)resto;
    }

}

Console.WriteLine(String.Join(", ", listaResultado));

#endregion


