using System.Data;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string entrada;

        do
        {
            Console.WriteLine("Menú");
            Console.WriteLine(" 1) sumatoria");
            Console.WriteLine(" 2) factorial");
            Console.WriteLine(" 3) tablas");
            Console.WriteLine(" 1) salida");
            Console.WriteLine("Ingrese un número 1-4 ");
            entrada = Console.ReadLine();
            try
            {
                opcion = int.Parse(entrada);
            }
            catch (FormatException)
            {
                Console.WriteLine("error");
            }
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese un número ");
                    string entradanumero = Console.ReadLine();
                    int n = 0;
                    try
                    {
                        n = int.Parse(entradanumero);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error, ingrese otro número");
                    }

                    int i=1;
                    int sumatoria=0;
                    while(i<=n)
                    {
                        sumatoria += i;
                        i++;
                    }

                    Console.WriteLine($"Sumatoria: {sumatoria}");
                    
                    break;

                case 2:
                    Console.WriteLine("Ingrese un número ");
                    string entradanumerof = Console.ReadLine();
                    int nf = 0;
                    try
                    {
                        nf = int.Parse(entradanumerof);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error, ingrese otro número");
                    }

                    int j=1;
                    int factorial=1;
                    while(j<=nf)
                    {
                         factorial *= j;
                        j++;
                    }

                    Console.WriteLine($"Factorial: {factorial}");
                    
                    break;
    

                case 3:
                string titulo = "\t" ;
                for (int ititulo = 1; ititulo <= 10; ititulo++)
                {
                    titulo += ititulo + "\t";
                }
                Console.WriteLine(titulo);

                string fila = "";
                for (int ifila = 1; ifila <= 10; ifila++)
                {
                    fila = ifila + "\t";
                    for (int multiplo = 1; multiplo <= 10; multiplo++)
                    {
                        fila+= ifila * multiplo + "\t";
                    }
                    Console.WriteLine(fila);

                }
                break;

                default:
                    Console.WriteLine("Error, ingrese un número del 1 al 4");
                    break;
            }
        }
        while (opcion != 4);
    }
}