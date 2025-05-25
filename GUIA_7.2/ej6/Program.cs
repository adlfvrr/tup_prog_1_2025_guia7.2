namespace ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j1, j2, set1 = 0, set2 = 0, prob = 0;
            string nomb1, nomb2;
            Console.WriteLine("Ingrese nombre del jugador 1: ");
            nomb1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del jugador 2: ");
            nomb2 = Console.ReadLine();

            // SET 1
            Console.Write("Ingrese juego del jugador 1: ");
            j1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese juego del jugador 2: ");
            j2 = Convert.ToInt32(Console.ReadLine());
            if (j1 >= 4)
            {
                if (j1 >= j2 + 2)
                {
                    Console.WriteLine($"Ganador del set: {nomb1}");
                    set1 = 1;
                }
                else
                {
                    if (j2 >= j1 + 2)
                    {
                        Console.WriteLine($"Ganador del set: {nomb2}");
                        set2 = 1;
                    }
                    else
                    {
                        Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                        prob = 1;
                    }
                }
            }
            else
            {
                if (j2 >= 4)
                {
                    if (j2 >= j1 + 2)
                    {
                        Console.WriteLine($"Ganador del set: {nomb2}");
                        set2 = 1;
                    }
                    else
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {nomb1}");
                            set1 = 1;
                        }
                        else
                        {
                            Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            prob = 1;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos");
                    prob = 1;
                }
            }
            //
            // SET 2
            if (prob < 1)
            {
                Console.WriteLine("Ingrese juego del jugador 1: ");
                j1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese juego del jugador 2: ");
                j2 = Convert.ToInt32(Console.ReadLine());
                if (j1 >= 4)
                {
                    if (j1 >= j2 + 2)
                    {
                        Console.WriteLine($"Ganador del set: {nomb1}");
                        if (set1 == 1)
                        {
                            Console.WriteLine($"Ganador del partido: {nomb1}");
                        }
                        else
                        {
                            set1 = 1;
                        }
                    }
                    else
                    {
                        if (j2 >= j1 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {nomb2}");
                            if (set2 == 1)
                            {
                                Console.WriteLine($"Ganador del partido: {nomb2}");
                            }
                            else
                            {
                                set2 = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            prob = 1;
                        }
                    }
                }
                else
                {
                    if (j2 >= 4)
                    {
                        if (j2 >= j1 + 2)
                        {
                            Console.WriteLine($"Ganador del set: {nomb2}");
                            if (set2 == 1)
                            {
                                Console.WriteLine($"Ganador del partido: {nomb2}");
                            }
                            else
                            {
                                set2 = 1;
                            }
                        }
                        else
                        {
                            if (j1 >= j2 + 2)
                            {
                                Console.WriteLine($"Ganador del set: {nomb1}");
                                if (set1 == 1)
                                {
                                    Console.WriteLine($"Ganador del partido: {nomb1}");
                                }
                                else
                                {
                                    set1 = 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                prob = 1;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("La puntuación mínima necesaria para ganar un set es de 4 puntos.");
                    }
                }
            }
            //
            //SET 3
            if (prob != 1)
            {
                if (set1 == 1 && set2 == 1)
                {
                    Console.WriteLine("Ingrese juego del jugador 1: ");
                    j1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese juego del jugador 2: ");
                    j2 = Convert.ToInt32(Console.ReadLine());
                    if (j1 >= 4)
                    {
                        if (j1 >= j2 + 2)
                        {
                            Console.WriteLine($"Ganador del partido: {nomb1}");
                        }
                        else
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del partido: {nomb2}");
                            }
                            else
                            {
                                Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                            }
                        }
                    }
                    else
                    {
                        if(j2 >= 4)
                        {
                            if (j2 >= j1 + 2)
                            {
                                Console.WriteLine($"Ganador del partido: {nomb2}");
                            }
                            else
                            {
                                if(j1 >= j2 + 2)
                                {
                                    Console.WriteLine($"Ganador del partido: {nomb1}");
                                }
                                else
                                {
                                    Console.WriteLine("No hay diferencia de 2 necesaria para ganar el set");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La puntuación minima necesaria para ganar un set es de 4 puntos.");
                        }
                    }
                }
            }
        }
    }
}