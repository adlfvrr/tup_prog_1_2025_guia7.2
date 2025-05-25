namespace ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.Write("Ingrese año: ");
            año = Convert.ToInt32(Console.ReadLine());
            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Es bisiesto");
                }
            }
            else {
                Console.WriteLine("No es bisiesto");           
            }
        }
    }
}