namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, prom, cond;
            Console.Write("Ingrese condición para promocionar: ");
            cond = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese nota de los 3 parciales: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            prom = (n1 + n2 + n3) / 3;
            if (prom >= cond) { Console.WriteLine("Promociona"); }
            else { Console.WriteLine("Rinde Final"); }
        }
    }
}
