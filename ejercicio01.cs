using System;

public class Unidad_4_ISNP152823_ISNP088623
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***************************");
        Console.WriteLine("**** Digite su nombre: ****");
        Console.WriteLine("***************************");
        string nombre = Console.ReadLine();
        if (nombre == "Fredy") 
        {
            Console.WriteLine("Usted está Autorizado");
            Console.WriteLine("Hola {0}", nombre);
        }
        else
        {
            Console.WriteLine("No te conozco {0}", nombre); 
    }
}
}
