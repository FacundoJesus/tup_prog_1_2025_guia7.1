namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int numero, parte_letras, parte_numerica;
            char letra1, letra2, letra3;
            string patente;
            #endregion

            #region Solicitud de datos
            Console.WriteLine("Ingrese un número entero:");
            numero = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Proceso
            parte_numerica = numero % 1000;
            parte_letras = numero / 1000;
            
            letra3 = (char)('A' + (parte_letras % 26));
            parte_letras = parte_letras / 26;

            letra2 = (char)('A' + (parte_letras % 26));
            parte_letras = parte_letras / 26;

            letra1 = (char)('A' + (parte_letras % 26));
            parte_letras = parte_letras / 26;

            patente = $"{letra1}{letra2}{letra3}{parte_numerica:D3}";
            #endregion

            #region Salida
            Console.WriteLine("Patente: " + patente);
            #endregion
        }
    }
}
