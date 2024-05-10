using System;

public class Unidad_4_ISNP152823_ISNP088623
{
    public static void Main(string[] args)
    {       
        Console.WriteLine("*******************************************");
        Console.WriteLine("* Ingrese la tabla que desea multiplicar: *");
        Console.WriteLine("*******************************************");
        int ntabla = int.Parse(Console.ReadLine());
       

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", ntabla, i, ntabla * i);
        }
    }
}
