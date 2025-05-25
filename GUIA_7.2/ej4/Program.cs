namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            mayor = n;
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor) { mayor = n; }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor) { mayor = n; }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor) { mayor = n; }
            Console.Write("Ingrese numero a procesar: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor) { mayor = n; }
            Console.WriteLine($"El numero mayor de los ingresados fue {mayor}");

        }
    }
}
