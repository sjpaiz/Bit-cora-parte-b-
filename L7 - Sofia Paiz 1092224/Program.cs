using System;

class Program 
{
    static void Main (string[] args)
    {
        Console.WriteLine("Laboratorio 07 - Sofia Paiz - 1092224");
        int NFibonacci;
        bool conversion = false;
        bool nPositivo = true;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conversion = int.TryParse(Console.ReadLine(), out NFibonacci);
            if (conversion)
            {
                if (NFibonacci > 0)
                {
                    nPositivo = true;
                }
                else
                {
                    nPositivo = false;
                    Console.WriteLine("Debe ingresar un número mayor a 0.");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido.");
            }
        }
        while (!conversion || !nPositivo);

        int a = 0;
        int b = 1;
        int c = 0;
        int i = 0;
        string resultado = "";

        if (NFibonacci > 0)
        {
            resultado = a + ",";
        }

        if (NFibonacci > 1)
        {
            resultado += b + ",";
        }

        while (i < NFibonacci - 2) 
        {
            c = a + b; 
            resultado += c + ",";
            a = b;
            b = c;
            i++;
        }

        Console.WriteLine($"La secuencia de Fibonacci hasta el número {NFibonacci} es: {resultado}");
    }
}













}

