namespace ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, menor = 0, orden;
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            menor = n;
            orden = 1;
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < menor) 
            { menor = n;
                orden = 2;
            }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < menor) { menor = n;
                orden = 3;
            }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < menor) { menor = n;
                orden = 4;
            }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < menor) { menor = n;
                orden = 5;
            }
            Console.WriteLine($"El numero menor de los ingresados fue {menor} en el orden {orden}");
        }
    }
}
