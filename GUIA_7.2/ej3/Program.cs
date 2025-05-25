namespace ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, nmayor, nmedio, nmenor;
            string al1, al2, al3, almayor, almedio, almenor;
            Console.WriteLine("Ingrese nombre del alumno y nota del parcial: ");
            al1 = Console.ReadLine();
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del alumno y nota del parcial: ");
            al2 = Console.ReadLine();
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del alumno y nota del parcial: ");
            al3 = Console.ReadLine();
            n3 = Convert.ToInt32(Console.ReadLine());
            
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    nmayor = n1;
                    almayor = al1;
                    if (n2 > n3)
                    {
                        nmedio = n2;
                        almedio = al2;
                        nmenor = n3;
                        almenor = al3;
                    }
                    else
                    {
                        nmedio = n3;
                        almedio = al3;
                        nmenor = n2;
                        almenor = al2;
                    }
                }
                else
                {
                    nmayor = n3;
                    almayor = al3;
                    nmedio = n1;
                    almedio = al1;
                    nmenor = n2;
                    almenor = al2;
                }
            }
            else
            {
                if (n2 > n3)
                {
                    nmayor = n2;
                    almayor = al2;
                    if (n3 > n1)
                    {
                        nmedio = n3;
                        almedio = al3;
                        nmenor = n1;
                        almenor = al1;
                    }
                    else
                    {
                        nmedio = n1;
                        almedio = al1;
                        nmenor = n3;
                        almenor = al3;
                    }
                }
                else
                {
                    nmayor = n3;
                    almayor = al3;
                    nmedio = n2;
                    almedio = al2;
                    nmenor = n1;
                    almenor = al1;
                }
            }
            Console.WriteLine($"El alumno con mayor nota es {almayor}, con una nota de {nmayor}. \n El alumno con nota media es {almedio}, con una nota de {nmedio}. \n Y el alumno con menor nota es {almenor}, con una nota de {nmenor}");
        }   
    }
} 
