namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Es negativo"); }

            else
            {
                if (n == 0) { Console.WriteLine("Es Cero"); }
                else
                {
                    Console.WriteLine("Es positivo");
                }
            }
        }
    }
}