// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresa un número para saber si es primo: ");
string numeroStr = Console.ReadLine();
int numero = int.Parse(numeroStr);
void numeroPrimo(int? numero)
{
    int? aux = numero - 1;
    while (aux > 1 && aux < numero)
    {
        if (numero % aux == 0)
        {
            Console.WriteLine("aux: " + aux);

            Console.WriteLine("El número" + numero + " NO es primo");
            break;
        }
        aux--;
    }

    Console.WriteLine("El número" + numero + " es primo");
}

numeroPrimo(numero);
