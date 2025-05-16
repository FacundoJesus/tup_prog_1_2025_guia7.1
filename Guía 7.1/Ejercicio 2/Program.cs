namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            double masa, masa_sobrante;
            int paquetes, budines, paquetes_sobrantes, cajas;
            #endregion

            #region Solicitud de Datos
            Console.WriteLine("Ingrese la cantidad de masa a producir: (kg)");
            masa = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Cálculos
            //Cantidad de budines
            budines = Convert.ToInt32(masa / 0.055);
            //Paquetes completos
            paquetes = budines / 12;
            //Cajas completos
            cajas = paquetes / 20;

            //Masa sobrante
            masa_sobrante = masa % 0.055;
            //Paquetes sobrantes
            paquetes_sobrantes =  budines % 12;
            #endregion

            #region Informe
            Console.WriteLine("Cantidad de budines: " + budines);
            Console.WriteLine("Cantidad de masa sobrante: " + masa_sobrante);
            Console.WriteLine("Cantidad de paquetes: " + paquetes);
            Console.WriteLine("Cantidad de cajas completas: " + cajas);
            #endregion
        }
    }
}
 