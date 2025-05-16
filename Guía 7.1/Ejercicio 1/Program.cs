using System.Diagnostics.CodeAnalysis;
using System.Timers;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int edad1, edad2, edad3, edad4, suma_edades;
            double monto, monto1, monto2, monto3, monto4, porc_edad1, porc_edad2, porc_edad3, porc_edad4;
            #endregion

            #region Solicitud de Datos
            Console.WriteLine("Ingrese el monto a repartir:");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la niña 1:");
            edad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la niña 2:");
            edad2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la niña 3:");
            edad3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la edad de la niña 4:");
            edad4 = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Proceso
            suma_edades = edad1 + edad2 + edad3 + edad4;

            porc_edad1 = ((double)edad1 / suma_edades)* 100;
            porc_edad2 = ((double)edad2 / suma_edades)* 100; 
            porc_edad3 = ((double)edad3 / suma_edades)* 100; 
            porc_edad4 = ((double)edad4 / suma_edades)* 100;

            
            monto1 = (porc_edad1 * monto) / 100;
            monto2 = (porc_edad2 * monto) / 100;
            monto3 = (porc_edad3 * monto) / 100;
            monto4 = (porc_edad4 * monto) / 100;
            #endregion

            #region Salidas
            Console.WriteLine($"Monto correspondiente para la niña 1: ${monto1:f2} y el porcentaje es: {porc_edad1:f0}%");
            Console.WriteLine($"Monto correspondiente para la niña 2: ${monto2:f2} y el porcentaje es: {porc_edad2:f0}%");
            Console.WriteLine($"Monto correspondiente para la niña 3: ${monto3:f2} y el porcentaje es: {porc_edad3:f0}%");
            Console.WriteLine($"Monto correspondiente para la niña 4: ${monto4:f2} y el porcentaje es: {porc_edad4:f0}%");
            #endregion
        }
    }
}
