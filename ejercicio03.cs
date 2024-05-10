using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] nombres = new string[5];
        double[] sueldos = new double[5];
        double sueldoMayor = 0;
        string nombreSueldoMayor = "";

      
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre del operario {0}: ", i + 1);
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese el sueldo del operario {0}: ", i + 1);
            sueldos[i] = Convert.ToDouble(Console.ReadLine());

            
            if (sueldos[i] > sueldoMayor)
            {
                sueldoMayor = sueldos[i];
                nombreSueldoMayor = nombres[i];
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("El operario con el sueldo mayor es: {0}", nombreSueldoMayor);
        Console.WriteLine("Su sueldo es: {0}", sueldoMayor);
    }
}
