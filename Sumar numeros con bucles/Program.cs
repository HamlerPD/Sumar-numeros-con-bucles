// Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.
int i = 0;
int j = 0;
int k = 0;
int l = 0;
int m = 0;
int n = 0;
int o = 0;
int p = 0;
int q = 0;
int r = 0;
int suma = 0;
int num = 0;

for (num = 1; num <= 10; num++)
{
    Console.WriteLine(" Ingresar 10 numeros");

    string linea = string.Empty;
    linea = Console.ReadLine();
    i = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    j = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    k = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    l = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    m = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    n = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    o = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    p = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    q = Convert.ToInt32(linea);

    linea = Console.ReadLine();
    r = Convert.ToInt32(linea);

    suma = p + q + r;
    Console.WriteLine(" La suma de los 3 ultimos numeros es igual a " + suma);
    Console.ReadLine();
}







