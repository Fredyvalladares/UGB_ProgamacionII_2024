using System;

public class Unidad_4_ISNP152823_ISNP088623
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*******************************************");
        Console.WriteLine("*** Los Números impares entre 0 y 100: ****");
        Console.WriteLine("*******************************************");
        Console.WriteLine("Presiona Cualquier Tecla para Continuar");
        Console.ReadKey();
        for (int i = 1; i <= 100; i += 2) 
        {
            Console.WriteLine(i);
             Console.ReadKey();
        }
    }
}
