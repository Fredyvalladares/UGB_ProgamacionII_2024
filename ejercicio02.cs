using System;

public class Unidad_4_ISNP152823_ISNP088623
{
    public static void Main(string[] args)
    {
        int suma = 0; 
        int num; 

        do
        {
            Console.Write("Ingrese un Numero Positivo Para Sumar: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                suma += num;
            }
        }
        while (num > 0);

        Console.WriteLine();
        Console.WriteLine("La Suma de los Numeros Positivos es: " + suma);
        Console.WriteLine();
        Console.WriteLine("Presiona Cualquier Tecla para Salir");
        Console.ReadKey();
    }
}
